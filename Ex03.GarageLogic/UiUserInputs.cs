using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{ 
  
    internal class UiUserInputs
    {
       
        string getVehicleLicenseNumber()
        {
            return Console.ReadLine();
        }
        int getVehicleType()
        {
            int optionOfVehicle;
            UITextMessages.carTypeMessage();
            Int32.TryParse(Console.ReadLine(), out optionOfVehicle);
            
        }
        int getCarElectricityCurrAmount()
        {
            int hoursOfElectricityInBattery; 
            UITextMessages.CarElectricityAmount();
            Int32.TryParse(Console.ReadLine(),out hoursOfElectricityInBattery);
        }
        
        int GetCarFuelCurrAmount()
        {
            int amountOfFuelInCar;
            UITextMessages.CarFuelCurrAmount();
            Int32.TryParse(Console.ReadLine(),out amountOfFuelInCar);
        }

        void getCarColor()
        {
            Console.ReadLine();
        }
        void getCarDoors()
        {
            Console.ReadLine();
        }
        void getMotorcycleLicenseType()
        {
            Console.ReadLine();
        }
        void getAirPressureInWheels()
        {
            Console.ReadLine();
        }
        void getIsRefrigeratorTruck()
        {
            Console.ReadLine();
        }
    }
}
