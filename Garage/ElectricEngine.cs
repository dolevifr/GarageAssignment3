namespace Garage
{
    public class ElectricEngine : Engine
    {
        public ElectricEngine(float MaxBatteryTimeCapacityHours) : base(MaxBatteryTimeCapacityHours) {}

        public float CurrentBatteryTimeHours
        {
            get { return base.m_currentEnergyCapacity; }
        }

        public float MaxBatteryTimeHours
        {
            get { return base.m_MaxEnergyCapacity; }
        }

        public void RechargeVehicle(float i_batteryTimeToAdd)
        {
            base.AddEnergy(i_batteryTimeToAdd);
        }
    }
}