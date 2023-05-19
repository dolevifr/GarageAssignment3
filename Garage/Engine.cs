using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Engine
    {
        public enum eEnergyType { Soler, Octan95, Octan96, Octan98, Electricity }

        protected float m_currentEnergyCapacity;
        protected float m_MaxEnergyCapacity;
        protected eEnergyType m_EnergyType;


        public eEnergyType FuelType
        {
            get { return m_EnergyType; }
        }


        public Engine(float i_MaxEnergyCapacity, eEnergyType i_EnergyType)
        {
            m_MaxEnergyCapacity = i_MaxEnergyCapacity;
            m_EnergyType = i_EnergyType;
        }
            
        public void AddEnergy(float i_energyToAdd, eEnergyType i_energyType)
        {

            if (m_EnergyType != i_energyType)
            {
                //throw exception
            }

            float energyCapacityAfterAdd = i_energyToAdd + m_currentEnergyCapacity;
            
            if (energyCapacityAfterAdd > m_MaxEnergyCapacity)
            {
                //TODO: throw exception instead
            }

            m_currentEnergyCapacity = energyCapacityAfterAdd;
        }

    }
}
