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
            if(!Int32.TryParse(Console.ReadLine(), out intToReturn))
            {
                //throw exception
            }
        }
        public string GetVehicleLicenseNumber()
        {
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
        public int GetIsRefrigeratorTruck()
        {
            int isRefrigeratorTruckOption;
            validateIntInput(UITextMessages.k_isRefrigeratorTruck, out isRefrigeratorTruckOption);
            return isRefrigeratorTruckOption;
        }
    }
}
