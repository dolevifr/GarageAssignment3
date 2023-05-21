using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class GarageInserter
    {
        private UiUserInputs userInput;
        
        public enum eCarType {Car, Motorcycle, Truck };
       public void InsertVehicle()
       {
            eCarType vehiclType;
            string licenseNUmber = userInput.GetVehicleLicenseNumber();
            string modelName = userInput.GetVehicleModelName();
            vehiclType = (eCarType)userInput.GetVehicleType();
            if(vehiclType == eCarType.Car)
            {
                if (userInput.IsElectricVehicle())
                {
                    int batteryHours = userInput.GetCarElectricityCurrAmount();
                }
                else
                {
                    int currFuelAmount = userInput.GetCarFuelCurrAmount();
                }
                string carColor = userInput.GetCarColor();
                int numOfCarDoors = userInput.GetCarDoors();

            }
            else if(vehiclType == eCarType.Motorcycle)
            {
                

            }

       }
    }
}
