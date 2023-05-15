using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Engine
    {
        protected float m_currentEnergyCapacity;
        protected float m_MaxEnergyCapacity;

        public Engine(float i_MaxEnergyCapacity)
        {
            m_MaxEnergyCapacity = i_MaxEnergyCapacity;
        }
            
        public void AddEnergy(float i_energyToAdd)
        {
            float energyCapacityAfterAdd = i_energyToAdd + m_currentEnergyCapacity;
            
            if (energyCapacityAfterAdd > m_MaxEnergyCapacity)
            {
                energyCapacityAfterAdd += 1; //TODO: throw exception instead
            }

            m_currentEnergyCapacity = energyCapacityAfterAdd;
        }

    }
}
