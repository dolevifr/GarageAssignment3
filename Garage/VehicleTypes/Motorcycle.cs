using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType { A1, A2, AA, B1 }

        private eLicenseType m_licenseType;
        int m_engineVolume;

        public Motorcycle(string i_licenseNumber, string i_modelName, int i_numOfWheels) :
            base(i_licenseNumber, i_modelName, i_numOfWheels) {}

        public eLicenseType LicenseType
        {
            get { return m_licenseType; }
            set { m_licenseType = value; }
        }

        public int EngineVolume
        {
            get { return m_engineVolume; }
            set { m_engineVolume = value; }
        }
    }
}
