namespace Ex03.GarageLogic
{
    class GarageLogicEngine
    {
        VehicleComponentFactory m_VehicleComponentFactory = new VehicleComponentFactory();
        VehicleFactory m_VehicleFactory = new VehicleFactory();
        GarageHandler m_GarageHandler = new GarageHandler();
        Vehicle m_CurrentVehicle;
        

        public void AddEngineToCurrentCar(DTO.EngineInformation engineInformation)
        {
            m_CurrentVehicle.Engine = m_VehicleComponentFactory.createEngine(engineInformation);
        }

        public void AddWheelsToCurrentCar(DTO.WheelsSetInformation i_wheelsToAdd)
        {
            m_CurrentVehicle.WheelLs = m_VehicleComponentFactory.createWheelsCollection(i_wheelsToAdd);
        }

        public bool isCarExistsInGarage(string i_licenseNumber)
        {
            return m_GarageHandler.IsVehicleInGarage(i_licenseNumber);
        }

        public void GetVehicleInfo()
        {

        }
    }
}
