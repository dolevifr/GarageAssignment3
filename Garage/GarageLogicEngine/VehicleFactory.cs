using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class VehicleFactory
    {
        public enum AllowedVehicleTypes { Car, Motorcycle, Truck }




        public Vehicle CreateCarFromInfo(DTO.VehicleInformation i_vehicleInformation, DTO.CarInformation i_carInformation)
        {
            return new Car(i_carInformation.m_colorOfCar, i_carInformation.m_numOfDoors,
                            i_vehicleInformation.m_licenseNumber, i_vehicleInformation.m_modelName, i_vehicleInformation.m_numOfWheels);
        }

        public Vehicle CreateMotorCycleFromInfo(DTO.VehicleInformation i_vehicleInformation, DTO.MotorcycleInformation i_motorcycleInformation)
        {
            return new Motorcycle(i_motorcycleInformation.m_licenseType, i_motorcycleInformation.m_engineVolume,
                i_vehicleInformation.m_licenseNumber, i_vehicleInformation.m_modelName, i_vehicleInformation.m_numOfWheels);
        }

        public Vehicle CreateTruckFromInfo(DTO.VehicleInformation vehicleInformation, DTO.TruckInformation truckInformation)
        {
            return new Truck(truckInformation.m_isCarryingDangerousMaterials, truckInformation.m_maxCargoLoad,
                vehicleInformation.m_licenseNumber, vehicleInformation.m_modelName, vehicleInformation.m_numOfWheels);
        }
    }
}
