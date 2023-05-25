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
            string allLicenseNumbers = m_garageLogicEngine.GetAllLicenseNumbersInGarage();
            System.Console.WriteLine(allLicenseNumbers);
        }

        private void getVehicleDetailsByLicenseNumber()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_getLicenseNumber);
            string vehicleDetails = m_garageLogicEngine.GetVehicleDetails(vehicleLicenseNumber);
            System.Console.WriteLine(vehicleDetails);
        }

        private void refuelVehicle()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_getLicenseNumber);
            Engine.eEnergyType fuelType = userInputManager.GetEnergyType();
            userInputManager.validateFloatInput(UITextMessages.k_fuelTheVehicleAmount, out float fuelToAddLiters);
            m_garageLogicEngine.RefuelVehicle(vehicleLicenseNumber, fuelType, fuelToAddLiters);
        }

        private void rechangeElectricVehicle()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_chargeTheVehicleLicenseNumber);
            userInputManager.validateFloatInput(UITextMessages.k_getBatteryTimeToAddMInutes, out float batteryTimeToAddMinutes);
            m_garageLogicEngine.RechargeVehicle(vehicleLicenseNumber, batteryTimeToAddMinutes / 60);
        }

        private void fillWheelsToMaxPSI()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_chargeTheVehicleLicenseNumber);
            m_garageLogicEngine.fillMaxPSIWheels(vehicleLicenseNumber);
        }
    }
}
