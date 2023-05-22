using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        readonly bool m_isCarryingDangerousMaterials;
        readonly float m_cargoVolume;

        public Truck(bool i_isCarryingDangerousMaterials, float i_maxCargoLoad, string i_licenseNumber, string i_modelName, int i_numOfWheels) :
            base(i_licenseNumber, i_modelName, i_numOfWheels)
        {
            m_isCarryingDangerousMaterials = i_isCarryingDangerousMaterials;
            m_cargoVolume = i_maxCargoLoad;
        }

        bool IsCarryingDangeriousMaterials
        {
            get { return m_isCarryingDangerousMaterials; }
        }

        float CargoVolume
        {
            get { return m_cargoVolume; }
        }
    }
}
