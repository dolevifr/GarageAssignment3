using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        bool m_isCarryingDangerousMaterials;
        float m_cargoVolume;

        public Truck(string i_licenseNumber, string i_modelName, int i_numOfWheels) :
            base(i_licenseNumber, i_modelName, i_numOfWheels) {}

        bool IsCarryingDangeriousMaterials
        {
            get { return m_isCarryingDangerousMaterials; }
            set { m_isCarryingDangerousMaterials = value; }
        }

        float CargoVolume
        {
            get { return m_cargoVolume; }
            set { m_cargoVolume = value; }
        }
    }
}
