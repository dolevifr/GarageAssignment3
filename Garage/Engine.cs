namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        public enum eEnergyType { Soler, Octan95, Octan96, Octan98, Electricity }

        protected eEnergyType m_EnergyType;
        protected float m_currentEnergyCapacity;
        protected float m_MaxEnergyCapacity;


        public eEnergyType FuelType
        {
            get { return m_EnergyType; }
        }

        public float EnergyPertencege
        {
            get { return m_currentEnergyCapacity / m_MaxEnergyCapacity; }
        }

        public Engine(eEnergyType i_EnergyType, float i_MaxEnergyCapacity, float i_initialEnergyCapacity)
        {
            if (i_initialEnergyCapacity > i_MaxEnergyCapacity)
            {
                //throw exception
            }

            m_currentEnergyCapacity = i_initialEnergyCapacity;
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
