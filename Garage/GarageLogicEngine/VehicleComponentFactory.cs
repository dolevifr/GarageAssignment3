using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    class VehicleComponentFactory
    {
        public List<Wheel> createWheelsCollection(int i_numOfWheels, string i_manufacturerName, int i_maxPSI)
        {
            List<Wheel> wheelList = new List<Wheel>(i_numOfWheels);

            for (int i = 0; i <i_numOfWheels; i++)
            {
                wheelList.Add(new Wheel(i_manufacturerName, i_maxPSI));
            }

            return wheelList;
        }

        public Engine createEngine(Engine.eEnergyType i_EnergyType, float m_MaxEnergyCapacity)
        {
            Engine currentEngine;

            if (i_EnergyType == Engine.eEnergyType.Electricity)
            {
                currentEngine = new ElectricEngine(m_MaxEnergyCapacity);
            }
            else
            {
                currentEngine = new FuelEngine(i_EnergyType, m_MaxEnergyCapacity);
            }

            return currentEngine;
        }
    }
}
