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
        public void GetVehicleBaseInformation(out string licenseNumber, out string ModelName,out int numOfWheels)
        {
            licenseNumber = DisplayMessageAndGetStringFromUser(UITextMessages.k_getLicenseNumber);
            ModelName = DisplayMessageAndGetStringFromUser(UITextMessages.k_vehicleModelName);
            validateIntInput(UITextMessages.k_wheelNumberInVehicle, out numOfWheels);
        }

        public string DisplayMessageAndGetStringFromUser(string messageToPrint)
        {
            Console.WriteLine(messageToPrint);
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
        public int GetMaxAirPressureInWheels()
        {
            int maxPressureInWheels;
            validateIntInput(UITextMessages.k_wheelsMaxAirPressure, out maxPressureInWheels);
            return maxPressureInWheels;
        }
        public Engine.eEnergyType GetEnergyType()
        {
            int numOfWheels;
            validateIntInput(UITextMessages.k_energyType, out numOfWheels);
            return (Engine.eEnergyType)(numOfWheels - 1);
        }

        public int GetMotorcycleLicenseType()
        {
            int licenseOption;
            validateIntInput(UITextMessages.k_motorcycleLicenseType, out licenseOption);
            return licenseOption;

        }
        public bool GetIsRefrigeratorTruck()
        {
            int isRefrigeratorTruckOption;
            validateIntInput(UITextMessages.k_isRefrigeratorTruck, out isRefrigeratorTruckOption);
            return isRefrigeratorTruckOption == 1;
        }
    }
}
