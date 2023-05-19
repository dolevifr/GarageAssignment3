namespace Garage
{
    public class ElectricEngine : Engine
    {
        public ElectricEngine(float i_MaxBatteryTimeCapacityHours) :
            base(i_MaxBatteryTimeCapacityHours, eEnergyType.Electricity) {}

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