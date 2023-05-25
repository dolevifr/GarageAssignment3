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
            userInput.GetVehicleBaseInformation(out string licenseNUmber, out string modelName, out int numOfWheels);
            VehicleFactory.AllowedVehicleTypes vehiclType;
            userInput.validateIntInput(UITextMessages.k_CarTypeMessage, out int vehicleTypeToCast);
            vehiclType = (VehicleFactory.AllowedVehicleTypes)(vehicleTypeToCast - 1);
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

                logicEngine.AddWheelsToCurrentCar(numOfWheels, userInput.DisplayMessageAndGetStringFromUser(UITextMessages.k_wheelManufacturerName), userInput.GetMaxAirPressureInWheels());
                logicEngine.AddVehicleToGarage("aaaaa", "0513135");
            }
        }


        private void insertCar()
        {
            userInput.DisplayMessageAndGetStringFromUser(UITextMessages.k_vehicleColor);
            userInput.validateIntInput(UITextMessages.k_numOfVehicleDoors, out int numOfCarDoors);
        }

        private void insertTruck()
        {
            bool isRefrigeratorTruck = userInput.GetIsRefrigeratorTruck();
            userInput.validateFloatInput(UITextMessages.k_truckCargoVolume,out float truckCargoVolume);
        }

        private void insertMotorcycle()
        {

            Motorcycle.eLicenseType motorcycleliLcenseType = (GarageLogic.Motorcycle.eLicenseType)userInput.GetMotorcycleLicenseType();
            userInput.validateIntInput(UITextMessages.k_truckCargoVolume, out int motorcycleENgineVolume);
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
