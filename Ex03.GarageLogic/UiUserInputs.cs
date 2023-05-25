using Ex03.GarageLogic;
using System;

namespace Ex03.ConsoleUI
{
    public class UiUserInputs
    {
        public void ValidateIntInput(string i_messageToPrint, out int o_intToReturn)
        {
            Console.WriteLine(i_messageToPrint);
            if (!int.TryParse(Console.ReadLine(), out o_intToReturn))
            {
                throw new FormatException("Invalid integer input");
            }
        }
        public void GetVehicleBaseInformation(out string o_ModelName,out int o_numOfWheels)
        {
            o_ModelName = DisplayMessageAndGetStringFromUser(UITextMessages.k_vehicleModelName);
            ValidateIntInput(UITextMessages.k_wheelNumberInVehicle, out o_numOfWheels);
        }

        public string DisplayMessageAndGetStringFromUser(string i_messageToPrint)
        {
            Console.WriteLine(i_messageToPrint);
            return Console.ReadLine();
        }

        public void ValidateFloatInput(string i_messageToPrint, out float o_floatToReturn)
        {
            Console.WriteLine(i_messageToPrint);
            if (!float.TryParse(Console.ReadLine(), out o_floatToReturn))
            {
                throw new FormatException("Invalid float input");
            }
        }
        public int GetMaxAirPressureInWheels()
        {
            int maxPressureInWheels;
            ValidateIntInput(UITextMessages.k_wheelsMaxAirPressure, out maxPressureInWheels);
            return maxPressureInWheels;
        }
        public Engine.eEnergyType GetEnergyType()
        {
            int numOfWheels;
            ValidateIntInput(UITextMessages.k_energyType, out numOfWheels);
            return (Engine.eEnergyType)(numOfWheels - 1);
        }

        public GarageHandler.eVehicleStatus GetVehicleStatus()
        {
            ValidateIntInput(UITextMessages.k_getVehicleNewStatusInGarage, out int vehicleStatus);
            return (GarageHandler.eVehicleStatus)(vehicleStatus - 1);
        }

        public int GetMotorcycleLicenseType()
        {
            int licenseOption;
            ValidateIntInput(UITextMessages.k_motorcycleLicenseType, out licenseOption);
            return licenseOption;

        }
        public bool GetIsCarryingDangeriousMaterials()
        {
            int isRefrigeratorTruckOption;
            ValidateIntInput(UITextMessages.k_isRefrigeratorTruck, out isRefrigeratorTruckOption);
            return isRefrigeratorTruckOption == 1;
        }
    }
}
