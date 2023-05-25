using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class GarageInserter
    {
        private UiUserInputs userInput = new UiUserInputs();
        private GarageLogicEngine logicEngine;


        public GarageInserter(GarageLogicEngine i_garageLogicEngine)
        {
            logicEngine = i_garageLogicEngine;
        }

        public void InsertVehicle()
        {
            VehicleFactory.AllowedVehicleTypes vehiclType;
            string licenseNUmber = userInput.DisplayMessageAndGetStringFromUser();
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

                insertEngine();
                logicEngine.AddWheelsToCurrentCar(numOfWheels, userInput.GetWheelManufacturerName(), userInput.GetMaxAirPressureInWheels());
                logicEngine.AddVehicleToGarage("aaaaa", "0513135");
            }
        }


        private void insertCar()
        {
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
            motorcycleliLcenseType = (GarageLogic.Motorcycle.eLicenseType)userInput.GetMotorcycleLicenseType();
            int motorcycleEngineVolume = userInput.GetEngineVolumeOfMotorcycle();
        }

        private void insertEngine()
        {
            Engine.eEnergyType energyType = userInput.GetEnergyType();
            string message = energyType == Engine.eEnergyType.Electricity ? UITextMessages.k_carElectricityCurrAmount : UITextMessages.k_carFuelCurrAmount;
            userInput.validateFloatInput(message, out float maxEnergyAmount);
            logicEngine.AddEngineToCurrentCar(energyType, maxEnergyAmount);
        }
    }
}
