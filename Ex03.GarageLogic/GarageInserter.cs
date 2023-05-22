namespace Ex03.ConsoleUI
{
    class GarageInserter
    {
        public enum eCarType { Car, Motorcycle, Truck };

        private UiUserInputs userInput;

       public void InsertVehicle()
       {
            eCarType vehiclType;
            string licenseNUmber = userInput.GetVehicleLicenseNumber();
            string modelName = userInput.GetVehicleModelName();
            vehiclType = (eCarType)userInput.GetVehicleType();
            if(vehiclType == eCarType.Car)
            {
                if (userInput.IsElectricVehicle())
                {
                    int batteryHours = userInput.GetCarElectricityCurrAmount();
                }
                else
                {
                    int currFuelAmount = userInput.GetCarFuelCurrAmount();
                }
                string carColor = userInput.GetCarColor();
                int numOfCarDoors = userInput.GetCarDoors();

            }
            else if(vehiclType == eCarType.Motorcycle)
            {
                

            }

       }
    }
}
