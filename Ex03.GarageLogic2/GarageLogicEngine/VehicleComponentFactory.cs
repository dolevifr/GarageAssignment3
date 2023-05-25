using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    class VehicleComponentFactory
    {
        public List<Wheel> CreateWheelsCollection(int i_numOfWheels, string i_manufacturerName, int i_maxPSI)
        {
            List<Wheel> wheelList = new List<Wheel>(i_numOfWheels);

            for (int i = 0; i <i_numOfWheels; i++)
            {
                wheelList.Add(new Wheel(i_manufacturerName, i_maxPSI));
            }

            return wheelList;
        }

        public Engine CreateEngine(Engine.eEnergyType i_EnergyType, float i_MaxEnergyCapacity)
        {
            Engine currentEngine;

            if (i_EnergyType == Engine.eEnergyType.Electricity)
            {
                currentEngine = new ElectricEngine(i_MaxEnergyCapacity);
            }
            else
            {
                currentEngine = new FuelEngine(i_EnergyType, i_MaxEnergyCapacity);
            }

            return currentEngine;
        }
    }
}
