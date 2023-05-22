using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{

    internal class UiUserInputs
    {
        private void validateIntInput(string messageToPrint, out int intToReturn)
        {
            Console.WriteLine(messageToPrint);
            if (!Int32.TryParse(Console.ReadLine(), out intToReturn))
            {
                //throw exception
            }
        }
        public string GetVehicleLicenseNumber()
        {
            return Console.ReadLine();
        }
        public string GetWheelManufacturerName()
        {
            Console.WriteLine(UITextMessages.k_wheelManufacturerName);
            return Console.ReadLine();
        }
        public int GetMaxAirPressureInWheels()
        {
            int maxPressureInWheels;
            validateIntInput(UITextMessages.k_wheelsMaxAirPressure, out maxPressureInWheels);
            return maxPressureInWheels;
        }
        public int GetNumberOfWheelsInVehicle()
        {
            int numOfWheels;
            validateIntInput(UITextMessages.k_wheelNumberInVehicle, out numOfWheels);
            return numOfWheels;
        }
        public string GetEnergyType()
        {
            Console.WriteLine(UITextMessages.k_energyType);
            return Console.ReadLine();
        }
        public int GetVehicleType()
        {
            int optionOfVehicle;
            validateIntInput(UITextMessages.k_CarTypeMessage, out optionOfVehicle);
            return optionOfVehicle;
        }
        public int GetCarElectricityCurrAmount()
        {
            int hoursOfElectricityInBattery;
            validateIntInput(UITextMessages.k_carElectricityCurrAmount, out hoursOfElectricityInBattery);
            return hoursOfElectricityInBattery;
        }
        public string GetVehicleModelName()
        {
            Console.WriteLine(UITextMessages.k_vehicleModelName);
            return Console.ReadLine();
        }
        public bool IsElectricVehicle()
        {
            int electricVehicle;
            validateIntInput(UITextMessages.k_isElectricVehicle, out electricVehicle);
            return electricVehicle == 1;
        }
        public int GetCarFuelCurrAmount()
        {
            int amountOfFuelInCar;
            validateIntInput(UITextMessages.k_carFuelCurrAmount, out amountOfFuelInCar);
            return amountOfFuelInCar;
        }

        public string GetCarColor()
        {
            Console.WriteLine(UITextMessages.k_vehicleColor);
            return Console.ReadLine();
        }
        public int GetCarDoors()
        {
            int numOfCarDoors;
            validateIntInput(UITextMessages.k_numOfVehicleDoors, out numOfCarDoors);
            return numOfCarDoors;
        }
        public int GetMotorcycleLicenseType()
        {
            int licenseOption;
            validateIntInput(UITextMessages.k_motorcycleLicenseType, out licenseOption);
            return licenseOption;

        }
        public int GetAirPressureInWheels()
        {
            int currAirPressure;
            validateIntInput(UITextMessages.k_wheelsCurrAirPressure, out currAirPressure);
            return currAirPressure;
        }
        public bool GetIsRefrigeratorTruck()
        {
            int isRefrigeratorTruckOption;
            validateIntInput(UITextMessages.k_isRefrigeratorTruck, out isRefrigeratorTruckOption);
            return isRefrigeratorTruckOption == 1;
        }
        public int GetEngineVolumeOfMotorcycle()
        {
            int EngineVolume;
            validateIntInput(UITextMessages.k_motorcycleEngineVolume, out EngineVolume);
            return EngineVolume;
        }
        public float GetCargoVolumeOfTruck()
        {
            float CargoVolume;
            Console.WriteLine(UITextMessages.k_TruckCargoVolume);
            if (!float.TryParse(Console.ReadLine(), out CargoVolume))
            {
                //throw exception
            }
            return CargoVolume;
        }
    }
}
