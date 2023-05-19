using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{ 
  
    internal class UiUserInputs
    {
        public string GetVehicleLicenseNumber()
        {
            return Console.ReadLine();
        }
        public int GetVehicleType()
        {
            int optionOfVehicle;
            Console.WriteLine(UITextMessages.k_CarTypeMessage);
            Int32.TryParse(Console.ReadLine(), out optionOfVehicle);
            return optionOfVehicle;
        }
        public int GetCarElectricityCurrAmount()
        {
            int hoursOfElectricityInBattery;
            Console.WriteLine(UITextMessages.k_carElectricityCurrAmount);
            Int32.TryParse(Console.ReadLine(),out hoursOfElectricityInBattery);
            return hoursOfElectricityInBattery;
        }
        
        public int GetCarFuelCurrAmount()
        {
            int amountOfFuelInCar;
            Console.WriteLine(UITextMessages.k_carFuelCurrAmount);
            Int32.TryParse(Console.ReadLine(), out amountOfFuelInCar);
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
            Console.WriteLine(UITextMessages.k_numOfVehicleDoors);
            Int32.TryParse(Console.ReadLine(),out numOfCarDoors);
            return numOfCarDoors;
        }
        public int GetMotorcycleLicenseType()
        {
            int licenseOption;
            Console.WriteLine(UITextMessages.k_motorcycleLicenseType);
            Int32.TryParse(Console.ReadLine(), out licenseOption);
            return licenseOption;

        }
        public int GetAirPressureInWheels()
        {
            int currAirPressure;
            Console.WriteLine(UITextMessages.k_wheelsCurrAirPressure);
            Int32.TryParse(Console.ReadLine(), out currAirPressure);
            return currAirPressure;
        }
        public int GetIsRefrigeratorTruck()
        {
            int isRefrigeratorTruckOption;
            Console.WriteLine(UITextMessages.k_isRefrigeratorTruck);
            Int32.TryParse(Console.ReadLine(), out isRefrigeratorTruckOption);
            return isRefrigeratorTruckOption;
        }
    }
}
