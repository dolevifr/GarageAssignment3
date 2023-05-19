using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class FuelEngine : Engine
    {

        private eEnergyType m_fuelType;

        public FuelEngine(float i_maxLiterCapacityLiter, eEnergyType i_energy_type)
            : base(i_maxLiterCapacityLiter, i_energy_type)
        {
            if (i_energy_type == eEnergyType.Electricity)
            {
                //throw exception
            }
        }

        public float CurrentFuelLeftLiters
        {
            get { return m_currentEnergyCapacity; }
        }

        public float MaxFuelLeftLiters
        {
            get { return m_MaxEnergyCapacity; }
        }
    }
}
