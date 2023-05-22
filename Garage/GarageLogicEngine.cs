using Ex03.GarageLogic;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class GarageLogicEngine
    {
        VehicleComponentFactory m_VehicleComponentFactory = new VehicleComponentFactory();
        VehicleFactory m_VehicleFactory = new VehicleFactory();
        GarageHandler m_GarageHandler = new GarageHandler();
        Vehicle m_CurrentVehicle;
        

        public void AddEngineToCurrentCar(Engine.eEnergyType i_EnergyType, float m_MaxEnergyCapacity)
        {
            m_CurrentVehicle.Engine = m_VehicleComponentFactory.createEngine(i_EnergyType, m_MaxEnergyCapacity);
        }

        public void AddWheelsToCurrentCar(int i_numOfWheels, string i_manufacturerName, int i_maxPSI)
        {
            m_CurrentVehicle.WheelLs = m_VehicleComponentFactory.createWheelsCollection(i_numOfWheels, i_manufacturerName, i_maxPSI);
        }

        public void isCarExistsInGarage(string i_licenseNumber)
        {
            
        }
    }
}
