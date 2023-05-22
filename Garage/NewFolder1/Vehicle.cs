using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected string m_modelName;
        protected string m_licenseNumber;
        protected int m_numOfWheels;
        protected List<Wheel> m_wheelsList = new List<Wheel>();
        protected Engine m_engineBase = null;

        public Vehicle(string i_licenseNumber, string i_modelName, int i_numOfWheels)
        {
            m_licenseNumber = i_licenseNumber;
            m_modelName = i_modelName;
            m_numOfWheels = i_numOfWheels;
        }

        public Engine Engine
        {
            set { m_engineBase = value; }
        }


        public string LicenseNumber
        {
            get { return m_licenseNumber; }
        }

        public string ModelName
        {
            get { return m_licenseNumber; }
        }

        public Engine.eEnergyType EngineType
        {
            get { return m_engineBase.FuelType; }
        }

        public void AddEnergy(float i_energyToAdd, Engine.eEnergyType i_EnergyType)
        {
            m_engineBase.AddEnergy(i_energyToAdd, i_EnergyType);
        }

        public void FillAllTiresToMaxPSI()
        {
            foreach (Wheel wheel in m_wheelsList)
            {
                wheel.FillToMaxAirPressur();
            }
        }
    }
}
