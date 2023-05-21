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

        Truck(string i_licenseNumber, string i_modelName, Engine i_engineBase, bool i_isCarryingDangerousMaterials, float i_maxCargoLoad) :
            base(i_licenseNumber, i_modelName, i_engineBase)
        {
        }
    }
}
