using Ex03.GarageLogic;
using System.Collections.Generic;

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

        public void isCarExistsInGarage(string i_licenseNumber)
        {
            return 
        }
    }
}
