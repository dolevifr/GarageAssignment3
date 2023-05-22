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
        private GarageLogic.GarageLogicEngine logicEngine = new GarageLogic.GarageLogicEngine();

        public enum eCarType { Car, Motorcycle, Truck };
        GarageLogic.Motorcycle motorcycle;
        GarageLogic.Motorcycle.eLicenseType motorcycleliLcenseType;
        public void InsertVehicle()
        {
            eCarType vehiclType;
            string licenseNUmber = userInput.GetVehicleLicenseNumber();
            string modelName = userInput.GetVehicleModelName();
            vehiclType = (eCarType)userInput.GetVehicleType();
            if (vehiclType == eCarType.Car)
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
            else if (vehiclType == eCarType.Motorcycle)
            {
                if (userInput.IsElectricVehicle())
                {
                    int batteryHours = userInput.GetCarElectricityCurrAmount();
                }
                else
                {
                    int currFuelAmount = userInput.GetCarFuelCurrAmount();
                }
                motorcycleliLcenseType = (GarageLogic.Motorcycle.eLicenseType)userInput.GetMotorcycleLicenseType();
                int motorcycleEngineVolume = userInput.GetEngineVolumeOfMotorcycle();
            }

<<<<<<< HEAD
            else if (vehiclType == eCarType.Truck)
=======
            else if(vehiclType == eCarType.Truck)
>>>>>>> 10e7cf2cc67e744587bf3cdd8757e9944432401a
            {
                bool isRefrigeratorTruck = userInput.GetIsRefrigeratorTruck();
                float truckCargoVolume = userInput.GetCargoVolumeOfTruck();
            }
<<<<<<< HEAD
        }
=======
       }
>>>>>>> 10e7cf2cc67e744587bf3cdd8757e9944432401a
    }
}
