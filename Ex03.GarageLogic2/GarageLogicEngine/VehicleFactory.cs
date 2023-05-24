using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class VehicleFactory
    {
        public enum AllowedVehicleTypes { Car, Motorcycle, Truck }


        public Vehicle createVehicle(AllowedVehicleTypes vehicleTypeToCreate, string i_licenseNumber, string i_carModelName, int i_numOfWheels)
        {
            Vehicle vehicleToBeCreated = null;

            switch (vehicleTypeToCreate)
            {
                case AllowedVehicleTypes.Car:
                    vehicleToBeCreated = createCarFromInfo(i_licenseNumber, i_carModelName, i_numOfWheels);
                    break;
                case AllowedVehicleTypes.Motorcycle:
                    vehicleToBeCreated = createMotorCycleFromInfo(i_licenseNumber, i_carModelName, i_numOfWheels);
                    break;
                case AllowedVehicleTypes.Truck:
                    vehicleToBeCreated = createTruckFromInfo(i_licenseNumber, i_carModelName, i_numOfWheels);
                    break;
                default:
                    throw new ArgumentException("Vehicle type is not supported in factory");
            }

            return vehicleToBeCreated;
        }

        private Vehicle createCarFromInfo(string i_licenseNumber, string i_carModelName, int i_numOfWheels)
        {
            return new Car(i_licenseNumber, i_carModelName, i_numOfWheels);
        }

        private Vehicle createMotorCycleFromInfo(string i_licenseNumber, string i_carModelName, int i_numOfWheels)
        {
            return new Motorcycle(i_licenseNumber, i_carModelName, i_numOfWheels);
        }

        private Vehicle createTruckFromInfo(string i_licenseNumber, string i_carModelName, int i_numOfWheels)
        {
            return new Truck(i_licenseNumber, i_carModelName, i_numOfWheels);
        }
    }
}
