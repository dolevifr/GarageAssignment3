using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class GarageUI
    {
        private UiUserInputs userInput = new UiUserInputs();
        private GarageLogicEngine m_garageLogicEngine = new GarageLogicEngine();
        private GarageInserter m_garageInserter;
        
        public GarageUI()
        {
            m_garageInserter = new GarageInserter(m_garageLogicEngine);
        }

        public void menu()
        {
            userInput.validateIntInput("menu", out int menuOptionChosen);
            switch (menuOptionChosen)
            {
                case 1:
                    m_garageInserter.InsertVehicle();
                    break;
                case 2:
                    m_garageLogicEngine.GetAllLicenseNumbersInGarage();
                    break;

            }
        }
    }
}
