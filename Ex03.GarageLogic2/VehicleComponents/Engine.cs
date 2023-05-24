namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        public enum eEnergyType { Soler, Octan95, Octan96, Octan98, Electricity }

        protected readonly eEnergyType m_EnergyType;
        protected readonly float m_MaxEnergyCapacity;
        protected float m_currentEnergyCapacity = 0;


        public Engine(eEnergyType i_EnergyType, float i_MaxEnergyCapacity)
        {
            m_MaxEnergyCapacity = i_MaxEnergyCapacity;
            m_EnergyType = i_EnergyType;
        }

        public eEnergyType EnergyType
        {
            get { return m_EnergyType; }
        }

        public float EnergyPertencege
        {
            get { return m_currentEnergyCapacity / m_MaxEnergyCapacity; }
        }
        
        public float MaxEnergyCapacity
        {
            get { return m_MaxEnergyCapacity; }
        }

        public abstract string GetEngineInfo();


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
