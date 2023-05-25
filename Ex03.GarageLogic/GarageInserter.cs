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
            string licenseNumber = userInput.DisplayMessageAndGetStringFromUser(UITextMessages.k_getLicenseNumber);
            
            if (!logicEngine.IsVehicleExistsInGarage(licenseNumber))
            {
                string ownersName = userInput.DisplayMessageAndGetStringFromUser(UITextMessages.k_vehicleOwnerName);
                string ownerPhoneNumber = userInput.DisplayMessageAndGetStringFromUser(UITextMessages.k_vehicleOwnerPhoneNumber);
                userInput.GetVehicleBaseInformation(out string modelName, out int numOfWheels);
                userInput.ValidateIntInput(UITextMessages.k_CarTypeMessage, out int vehicleTypeToCast);
                VehicleFactory.AllowedVehicleTypes vehiclType = (VehicleFactory.AllowedVehicleTypes)(vehicleTypeToCast - 1);
                logicEngine.CreateVehicle(vehiclType, licenseNumber, modelName, numOfWheels);


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
                insertWheels(numOfWheels);
                logicEngine.AddVehicleToGarage(ownersName, ownerPhoneNumber);
            }
            else
            {
                System.Console.WriteLine(UITextMessages.k_isVehicleExistsInTheGarage);
                logicEngine.ChangeVehicleStatus(licenseNumber, GarageHandler.eVehicleStatus.InRepair);
            }
        }

        private void insertWheels(int i_numOfWheels)
        {
            logicEngine.AddWheelsToCurrentCar(i_numOfWheels, userInput.DisplayMessageAndGetStringFromUser(UITextMessages.k_wheelManufacturerName), userInput.GetMaxAirPressureInWheels());
            userInput.ValidateIntInput(UITextMessages.k_wheelsCurrAirPressure, out int PSI);
            logicEngine.InitializePSIInVehicle(PSI);
        }

        private void insertCar()
        {
            string color = userInput.DisplayMessageAndGetStringFromUser(UITextMessages.k_vehicleColor);
            userInput.ValidateIntInput(UITextMessages.k_numOfVehicleDoors, out int numOfCarDoors);
            logicEngine.AddUniqueFieldsForCar(numOfCarDoors, color);
        }

        private void insertTruck()
        {
            bool isCarryingDangeriousMaterials = userInput.GetIsCarryingDangeriousMaterials();
            userInput.ValidateFloatInput(UITextMessages.k_truckCargoVolume, out float truckCargoVolume);
            logicEngine.AddUniqueFieldsForTruck(isCarryingDangeriousMaterials, truckCargoVolume);
        }

        private void insertMotorcycle()
        {
            Motorcycle.eLicenseType motorcycleliLcenseType = (GarageLogic.Motorcycle.eLicenseType)userInput.GetMotorcycleLicenseType();
            userInput.ValidateIntInput(UITextMessages.k_truckCargoVolume, out int motorcycleEngineVolume);
            logicEngine.AddUniqueFieldsForMotorcycle(motorcycleliLcenseType, motorcycleEngineVolume);
        }

        private void insertEngine()
        {
            Engine.eEnergyType energyType = userInput.GetEnergyType();
            string message = energyType == Engine.eEnergyType.Electricity ? UITextMessages.k_carElectricityCurrAmount : UITextMessages.k_carFuelCurrAmount;
            userInput.ValidateFloatInput(message, out float maxEnergyAmount);
            logicEngine.AddEngineToCurrentCar(energyType, maxEnergyAmount);
            
            if (energyType != Engine.eEnergyType.Electricity)
            {
                userInput.ValidateFloatInput(UITextMessages.k_fuelTheVehicleAmount, out float fuelTheVehicleAmount);
                logicEngine.InitializeEnergyInVehicle(energyType, fuelTheVehicleAmount);
            }
            else
            {
                userInput.ValidateFloatInput(UITextMessages.k_initialMinutesAmountInBattery, out float minutesOfCharge);
                logicEngine.InitializeEnergyInVehicle(energyType, minutesOfCharge / 60);
            }
        }
    }
}
