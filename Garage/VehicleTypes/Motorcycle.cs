using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType{ A1, A2, AA, B1 }

        eLicenseType m_licenseType;
        int m_engineVolume;

        public Motorcycle(eLicenseType i_licenseType, int i_engineVolume, string i_licenseNumber, string i_modelName, Engine i_engineBase, List<Wheel> wheelList) : base(i_licenseNumber, i_modelName, wheelList, i_engineBase)
        {
            m_engineVolume = i_engineVolume;
            m_licenseType = i_licenseType;
        }
    }
}
