using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class RegularEngine : Engine
    {
        public enum eFuelType{Soler, Octan95, Octan96, Octan98}

        private eFuelType m_fuelType;

        public ElectricEngine(float i_maxLiterCapacityLiter)
            : base(i_maxLiterCapacityLiter)
        {

        }

        public float CurrentFuelLeftLiters
        {
            get { return base.m_currentEnergyCapacity; }
        }

        public float MaxFuelLeftLiters
        {
            get { return base.m_MaxEnergyCapacity; }
        }

        public void RecfuleVehicle(float i_batteryTimeToAdd, eFuelType i_fuelType)
        {
            if(m_fuelType == i_fuelType)
                m_fuelType += 1; //throw exception
            
            base.AddEnergy(i_batteryTimeToAdd);
        }
    }
}
