using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    class VehicleComponentFactory
    {
        public List<Wheel> createWheelsCollection(DTO.WheelsSetInformation i_wheelsSetInformation)
        {
            List<Wheel> wheelList = new List<Wheel>(i_wheelsSetInformation.m_NumOfWheels);

            for (int i = 0; i < i_wheelsSetInformation.m_NumOfWheels; i++)
            {
                wheelList.Add(new Wheel(i_wheelsSetInformation.m_manufacturerName, i_wheelsSetInformation.m_maxPSI));
            }

            return wheelList;
        }

        public Engine createEngine(Engine.eEnergyType i_EnergyType, float m_MaxEnergyCapacity)
        {
            Engine currentEngine;

            if (i_engineInformation.m_EnergyType == Engine.eEnergyType.Electricity)
            {
                currentEngine = new ElectricEngine(i_engineInformation.m_MaxEnergyCapacity);
            }
            else
            {
                currentEngine = new FuelEngine(i_engineInformation.m_EnergyType, i_engineInformation.m_MaxEnergyCapacity);
            }

            return currentEngine;
        }
    }
}
