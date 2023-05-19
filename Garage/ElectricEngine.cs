namespace Garage
{
    public class ElectricEngine : Engine
    {
        public ElectricEngine(float i_intialBatteryTimeHours, float i_MaxBatteryTimeHours) :
            base(eEnergyType.Electricity, i_intialBatteryTimeHours, i_MaxBatteryTimeHours) {}

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