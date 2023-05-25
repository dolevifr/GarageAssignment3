using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class GarageUI
    {
        private UiUserInputs userInputManager = new UiUserInputs();
        private GarageLogicEngine m_garageLogicEngine = new GarageLogicEngine();
        private GarageInserter m_garageInserter;
        private GarageHandler m_garageHandler = new GarageHandler();

        public GarageUI()
        {
            m_garageInserter = new GarageInserter(m_garageLogicEngine);
        }

        public void menu()
        {
            userInputManager.ValidateIntInput(UITextMessages.k_welcomeMenu, out int menuOptionChosen);

            switch (menuOptionChosen)
            {
                case 1:
                    m_garageInserter.InsertVehicle();
                    break;
                case 2:
                    getLicenseNumbersInGarage();
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

        private GarageHandler.eVehicleStatus? GetStatusToFilter()
        {
            userInputManager.ValidateIntInput(UITextMessages.k_statusToFilterBy, out int statusFilter);
            return statusFilter == 4 ? null : (GarageHandler.eVehicleStatus?)(statusFilter - 1);
        }

        private void getLicenseNumbersInGarage()
        {
            string allLicenseNumbers = m_garageLogicEngine.GetAllLicenseNumbersInGarage(GetStatusToFilter());
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
            userInputManager.ValidateFloatInput(UITextMessages.k_fuelTheVehicleAmount, out float fuelToAddLiters);
            m_garageLogicEngine.RefuelVehicle(vehicleLicenseNumber, fuelType, fuelToAddLiters);
        }

        private void rechangeElectricVehicle()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_chargeTheVehicleLicenseNumber);
            userInputManager.ValidateFloatInput(UITextMessages.k_getBatteryTimeToAddMInutes, out float batteryTimeToAddMinutes);
            m_garageLogicEngine.RechargeVehicle(vehicleLicenseNumber, batteryTimeToAddMinutes / 60);
        }

        private void fillWheelsToMaxPSI()
        {
            string vehicleLicenseNumber = userInputManager.DisplayMessageAndGetStringFromUser(UITextMessages.k_chargeTheVehicleLicenseNumber);
            m_garageLogicEngine.FillMaxPSIWheels(vehicleLicenseNumber);
        }
    }
}
