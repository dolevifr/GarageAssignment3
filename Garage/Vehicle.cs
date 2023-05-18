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
        public Vehicle(string i_licenseNumber, string i_modelName, Engine i_engineBase)
        {
            m_licenseNumber = i_licenseNumber;
            m_modelName = i_modelName;
            m_engineBase = i_engineBase;
        }
        public string LicenseNumber
        {
            get
            {
                return m_licenseNumber;
            }
           
        }
    }
}
