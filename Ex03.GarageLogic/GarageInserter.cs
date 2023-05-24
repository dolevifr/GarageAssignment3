using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class GarageInserter
    {
        public enum eCarType { Car, Motorcycle, Truck };


        private UiUserInputs userInput = new UiUserInputs();
        private GarageLogic.GarageLogicEngine logicEngine = new GarageLogic.GarageLogicEngine();
        private GarageLogic.Engine.eEnergyType eEnergyType;
        GarageLogic.Motorcycle motorcycle;
        GarageLogic.Motorcycle.eLicenseType motorcycleliLcenseType;

        public void InsertVehicle()
        {
            eCarType vehiclType;
            string licenseNUmber = userInput.GetVehicleLicenseNumber();
            string modelName = userInput.GetVehicleModelName();
            vehiclType = (eCarType)userInput.GetVehicleType();
            if (!logicEngine.isVehicleExistsInGarage(licenseNUmber))
            {
                if (vehiclType == eCarType.Car)
                {
                    insertCar();
                }
                else if (vehiclType == eCarType.Motorcycle)
                {
                    insertMotorcycle();
                }
                else if (vehiclType == eCarType.Truck)
                {
                    insertTruck();
                }
            }
        }

        private void insertCar()
        {
            electricOrRegularEngine();
            string carColor = userInput.GetCarColor();
            int numOfCarDoors = userInput.GetCarDoors();
            logicEngine.AddWheelsToCurrentCar(userInput.GetNumberOfWheelsInVehicle(), userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());
        }

        private void insertTruck()
        {
            bool isRefrigeratorTruck = userInput.GetIsRefrigeratorTruck();
            float truckCargoVolume = userInput.GetCargoVolumeOfTruck();
            logicEngine.AddWheelsToCurrentCar(userInput.GetNumberOfWheelsInVehicle(), userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());
        }

        private void insertMotorcycle()
        {
            electricOrRegularEngine();
            motorcycleliLcenseType = (GarageLogic.Motorcycle.eLicenseType)userInput.GetMotorcycleLicenseType();
            logicEngine.AddWheelsToCurrentCar(userInput.GetNumberOfWheelsInVehicle(), userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());
            int motorcycleEngineVolume = userInput.GetEngineVolumeOfMotorcycle();
        }

        private void electricOrRegularEngine()
        {
            if (userInput.IsElectricVehicle())
            {
                logicEngine.AddEngineToCurrentCar(GarageLogic.Engine.eEnergyType.Electricity, userInput.GetCarElectricityCurrAmount());
            }
            else
            {
                logicEngine.AddEngineToCurrentCar(GarageLogic.Engine.eEnergyType.Octan98, userInput.GetCarFuelCurrAmount());
            }
        }
    }
}
