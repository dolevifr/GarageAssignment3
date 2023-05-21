using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        bool m_isCarryingDangerousMaterials;
        float m_maxCargoLoad;

        public Truck(bool i_isCarryingDangerousMaterials, float i_maxCargoLoad, string i_licenseNumber, string i_modelName, Engine i_engineBase, List<Wheel> wheelsList) :
            base(i_licenseNumber, i_modelName, wheelsList,i_engineBase)
        {
            m_isCarryingDangerousMaterials = i_isCarryingDangerousMaterials;
            m_maxCargoLoad = i_maxCargoLoad;
        }
    }
}
