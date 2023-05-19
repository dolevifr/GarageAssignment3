using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Vehicle
    {
        protected string m_modelName;
        protected string m_licenseNumber;
        protected List<Wheel> m_wheelsList;
        protected Engine m_engineBase;

        public Vehicle(string i_licenseNumber, string i_modelName, List<Wheel> i_wheelList, Engine i_engineBase)
        {
            m_licenseNumber = i_licenseNumber;
            m_modelName = i_modelName;
            m_engineBase = i_engineBase;
            m_wheelsList = i_wheelList;
        }

        public string LicenseNumber
        {
            get { return m_licenseNumber;}
        }

        public string ModelName
        {
            get { return m_licenseNumber;}
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
            foreach(Wheel wheel in m_wheelsList)
            {
                wheel.FillToMaxAirPressur();
            }
        }

    }
}
