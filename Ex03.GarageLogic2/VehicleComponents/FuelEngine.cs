namespace Ex03.GarageLogic
{
    public class FuelEngine : Engine
    {
        public FuelEngine(eEnergyType i_energy_type, float i_maxFuelCapacityLiter)
            : base(i_energy_type, i_maxFuelCapacityLiter)
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

        public override string GetEngineInfo()
        {
            return string.Format($@"Energy Type: {EnergyType}
                                    Fuel left in liters: {CurrentFuelLeftLiters}/{MaxFuelLeftLiters}");
        }
    }
}
