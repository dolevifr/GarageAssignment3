namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        public ElectricEngine(float i_MaxBatteryTimeHours) :
            base(eEnergyType.Electricity, i_MaxBatteryTimeHours) {}

        public float CurrentBatteryTimeHours
        {
            get { return m_currentEnergyCapacity; }
        }

        public float MaxBatteryTimeHours
        {
            get { return m_MaxEnergyCapacity; }
        }
    }
}