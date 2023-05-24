using Ex03.GarageLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    class GarageInserter
    {


        private UiUserInputs userInput = new UiUserInputs();
        private GarageLogic.GarageLogicEngine logicEngine = new GarageLogic.GarageLogicEngine();
        private GarageLogic.Engine.eEnergyType eEnergyType;
        GarageLogic.Motorcycle.eLicenseType motorcycleliLcenseType;


        public void InsertVehicle()
        {
            VehicleFactory.AllowedVehicleTypes vehiclType;
            string licenseNUmber = userInput.GetVehicleLicenseNumber();
            string modelName = userInput.GetVehicleModelName();
            vehiclType = (VehicleFactory.AllowedVehicleTypes)(userInput.GetVehicleType() - 1);
            int numOfWheels = userInput.GetNumberOfWheelsInVehicle();
            logicEngine.CreateVehicle(vehiclType, licenseNUmber, modelName, numOfWheels);
            if (!logicEngine.isVehicleExistsInGarage(licenseNUmber))
            {
                if (vehiclType == VehicleFactory.AllowedVehicleTypes.Car)
                {
                    insertCar();
                }
                else if (vehiclType == VehicleFactory.AllowedVehicleTypes.Motorcycle)
                {
                    insertMotorcycle();
                }
                else if (vehiclType == VehicleFactory.AllowedVehicleTypes.Truck)
                {
                    insertTruck();
                }
                logicEngine.AddWheelsToCurrentCar(numOfWheels, userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());
            }
            Console.WriteLine(logicEngine.GetAllLicenseNumbersInGarage());
        }

     
        private void insertCar()
        {
            electricOrRegularEngine();
            string carColor = userInput.GetCarColor();
            int numOfCarDoors = userInput.GetCarDoors();
        }

        private void insertTruck()
        {
            bool isRefrigeratorTruck = userInput.GetIsRefrigeratorTruck();
            float truckCargoVolume = userInput.GetCargoVolumeOfTruck();
        }

        private void insertMotorcycle()
        {
            electricOrRegularEngine();
            motorcycleliLcenseType = (GarageLogic.Motorcycle.eLicenseType)userInput.GetMotorcycleLicenseType();
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
