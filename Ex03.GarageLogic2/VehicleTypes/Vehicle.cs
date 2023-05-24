using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected readonly string m_modelName;
        protected readonly string m_licenseNumber;
        protected readonly int m_numOfWheels;
        protected readonly List<Wheel> m_wheelsList = new List<Wheel>();
        protected Engine m_vehicleEngine = null;

        public Vehicle(string i_licenseNumber, string i_modelName, int i_numOfWheels)
        {
            m_licenseNumber = i_licenseNumber;
            m_modelName = i_modelName;
            m_numOfWheels = i_numOfWheels;
        }

        public Engine Engine
        {
            set { m_vehicleEngine = value; }
        }

        public List<Wheel> Wheels
        {
            set
            {
                if(value.Count != m_numOfWheels)
                {
                    //throw exception
                }

                m_wheelsList.Clear();
                foreach (Wheel wheel in value)
                {
                    m_wheelsList.Add(wheel);
                }
            }
        }

        public int WheelsNum
        {
            get { return m_numOfWheels; }
        }
        
        public string LicenseNumber
        {
            get { return m_licenseNumber; }
        }

        public string ModelName
        {
            get { return m_licenseNumber; }
        }

        public float MaxPSI
        {
            get { return m_wheelsList[0].MaxPSI; }
        }
        
        public float MaxEngineCapacity
        {
            get { return m_vehicleEngine.MaxEnergyCapacity; }
        }
        public Engine.eEnergyType EngineType
        {
            get { return m_vehicleEngine.EnergyType; }
        }

        public void AddEnergy(float i_energyToAdd, Engine.eEnergyType i_EnergyType)
        {
            m_vehicleEngine.AddEnergy(i_energyToAdd, i_EnergyType);
        }

        public void FillAllTiresToMaxPSI()
        {
            foreach (Wheel wheel in m_wheelsList)
            {
                wheel.FillToMaxAirPressur();
            }
        }

        public string displayWheelListDetails()
        {
            StringBuilder WheelInfoStringBuilder = new StringBuilder();
            foreach(Wheel wheelOfVehicle in m_wheelsList)
            {
                WheelInfoStringBuilder.AppendLine(wheelOfVehicle.DisplayWheelDetail());
            }

            return WheelInfoStringBuilder.ToString();
        }

        public virtual string DisplayDetails()
        {
            return string.Format($@"Model Name:       {m_modelName}
                                    License Number:   {m_licenseNumber}
                                    Number of Wheels: {m_numOfWheels}

                                    Wheels Info:
                                    {displayWheelListDetails()}

                                    Engine Info:
                                    {m_vehicleEngine.GetEngineInfo()}");
        }
    }
}
