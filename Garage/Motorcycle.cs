using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType{ A1, A2, AA, B1 }
        eLicenseType m_licenseType;
        int m_engineVolume;
        Motorcycle(string i_licenseNumber, string i_modelName, Engine i_engineBase,int i_engineVolume,eLicenseType i_licenseType) : base(i_licenseNumber, i_modelName, i_engineBase)
        {
            m_engineVolume = i_engineVolume;
            m_licenseType = i_licenseType;
        }
    }
    

    
}
