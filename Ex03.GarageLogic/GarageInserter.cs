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
        private GarageLogic.Engine.eEnergyType eEnergyType;
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
                    logicEngine.AddEngineToCurrentCar(GarageLogic.Engine.eEnergyType.Electricity, userInput.GetCarElectricityCurrAmount());
                }
                else
                {
                    logicEngine.AddEngineToCurrentCar(GarageLogic.Engine.eEnergyType.Octan95, userInput.GetCarFuelCurrAmount());
                }
                string carColor = userInput.GetCarColor();
                int numOfCarDoors = userInput.GetCarDoors();
                logicEngine.AddWheelsToCurrentCar(userInput.GetNumberOfWheelsInVehicle(), userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());
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
                logicEngine.AddWheelsToCurrentCar(userInput.GetNumberOfWheelsInVehicle(), userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());
                int motorcycleEngineVolume = userInput.GetEngineVolumeOfMotorcycle();
            }
            else if(vehiclType == eCarType.Truck)
            {
                bool isRefrigeratorTruck = userInput.GetIsRefrigeratorTruck();
                float truckCargoVolume = userInput.GetCargoVolumeOfTruck();
                logicEngine.AddWheelsToCurrentCar(userInput.GetNumberOfWheelsInVehicle(), userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());

            }
        }
    }
}
