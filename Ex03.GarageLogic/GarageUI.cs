using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class GarageUI
    {
        private UiUserInputs userInputManager = new UiUserInputs();
        private GarageLogicEngine m_garageLogicEngine = new GarageLogicEngine();
        private GarageInserter m_garageInserter;
        
        public GarageUI()
        {
            m_garageInserter = new GarageInserter(m_garageLogicEngine);
        }

        public void menu()
        {
            userInputManager.validateIntInput(UITextMessages.k_welcomeMenu, out int menuOptionChosen);
            
            switch (menuOptionChosen)
            {
                case 1:
                    m_garageInserter.InsertVehicle();
                    break;
                case 2:
                    getAllLicenseNumbersInGarage();
                    break;
                case 3:
                    changeVehicleStatusInGarage();
                    break;
                case 4:
                    fillWheelsToMaxPSI();
                    break;
                case 5:
                    refuelVehicle();
                    break;
                case 6:
                    rechangeElectricVehicle();
                    break;
                case 7:
                    getVehicleDetailsByLicenseNumber();
                    break;
                default:
                    System.Console.WriteLine(UITextMessages.k_invalidMenuItem);
                    break;
            }
        }

        private void changeVehicleStatusInGarage()
        {
            string licenseNumberOfVehicle = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_chargeTheVehicleLicenseNumber);
            GarageHandler.eVehicleStatus newVehicleStatus = userInputManager.GetVehicleStatus();
            m_garageLogicEngine.ChangeVehicleStatus(licenseNumberOfVehicle, newVehicleStatus);
        }

        private void getAllLicenseNumbersInGarage()
        {
            //TODO: get vehicle status or return 
            m_garageLogicEngine.GetAllLicenseNumbersInGarage();
        }

        private void getVehicleDetailsByLicenseNumber()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_getLicenseNumber);
            m_garageLogicEngine.GetVehicleDetails(vehicleLicenseNumber);
        }

        private void refuelVehicle()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_getLicenseNumber);
            Engine.eEnergyType fuelType = userInputManager.GetEnergyType();
            float fuelToAddLiters = userInputManager.getAndParseFloatFromUser(UITextMessages.k_fuelTheVehicleAmount);
            
            m_garageLogicEngine.RefuelVehicle(vehicleLicenseNumber, fuelType, fuelToAddLiters);
        }

        private void rechangeElectricVehicle()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_chargeTheVehicleLicenseNumber);
            float batteryTimeToAddMinutes = userInputManager.getAndParseFloatFromUser(UITextMessages.k_getBatteryTimeToAddMInutes);
            
            m_garageLogicEngine.RechargeVehicle(vehicleLicenseNumber, batteryTimeToAddMinutes);
        }

        private void fillWheelsToMaxPSI()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_chargeTheVehicleLicenseNumber);
            m_garageLogicEngine.fillMaxPSIWheels(vehicleLicenseNumber);
        }
    }
}
