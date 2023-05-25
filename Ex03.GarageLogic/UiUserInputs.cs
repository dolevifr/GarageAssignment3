using Ex03.GarageLogic;
using System;

namespace Ex03.ConsoleUI
{
    public class UiUserInputs
    {
        public void validateIntInput(string messageToPrint, out int intToReturn)
        {
            Console.WriteLine(messageToPrint);
            if (!int.TryParse(Console.ReadLine(), out intToReturn))
            {
                throw new FormatException("Invalid integer input");
            }
        }

        public int getAndParseInputFromUser(string messageToPrint)
        {
            Console.WriteLine(messageToPrint);
            return int.Parse(Console.ReadLine());
        }

        public float getAndParseFloatFromUser(string messageToPrint)
        {
            Console.WriteLine(messageToPrint);
            return float.Parse(Console.ReadLine());
        }

        public int getAndParseIntegerFromUser(string messageToPrint)
        {
            Console.WriteLine(messageToPrint);
            return int.Parse(Console.ReadLine());
        }

        public string DisplayMessageAndGetStringFromUser(string messageToPrint)
        {
            Console.WriteLine(UITextMessages.k_getLicenseNumber);
            return Console.ReadLine();
        }

        public string DisplayMessageAndGetStringFromUser()
        {
            Console.WriteLine(UITextMessages.k_getLicenseNumber);
            return Console.ReadLine();
        }

        public void validateFloatInput(string messageToPrint, out float floatToReturn)
        {
            Console.WriteLine(messageToPrint);
            if (!float.TryParse(Console.ReadLine(), out floatToReturn))
            {
                throw new FormatException("Invalid float input");
            }
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
        public Engine.eEnergyType GetEnergyType()
        {
            int numOfWheels;
            validateIntInput(UITextMessages.k_energyType, out numOfWheels);

            return (Engine.eEnergyType)(numOfWheels - 1);
        }

        public GarageHandler.eVehicleStatus GetVehicleStatus()
        {
            int vehicleStatus = getAndParseIntegerFromUser(UITextMessages.k_getVehicleNewStatusInGarage);
            return (GarageHandler.eVehicleStatus)(vehicleStatus - 1);
        }

        public int GetVehicleType()
        {
            int optionOfVehicle;
            validateIntInput(UITextMessages.k_CarTypeMessage, out optionOfVehicle);
            return optionOfVehicle;
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
            validateFloatInput(UITextMessages.k_truckCargoVolume, out float cargoVolume);
            return cargoVolume;
        }
    }
}
