using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool m_isCarryingDangerousMaterials;
        private float m_cargoVolume;

        public Truck(string i_licenseNumber, string i_modelName, int i_numOfWheels) :
            base(i_licenseNumber, i_modelName, i_numOfWheels) {}

        public bool IsCarryingDangeriousMaterials
        {
            get { return m_isCarryingDangerousMaterials; }
            set { m_isCarryingDangerousMaterials = value; }
        }

        public float CargoVolume
        {
            get { return m_cargoVolume; }
            set { m_cargoVolume = value; }
        }

        public override string DisplayDetails()
        {
            StringBuilder detailsForTruckStringBuilder = new StringBuilder();
            detailsForTruckStringBuilder.AppendLine(base.DisplayDetails());
            detailsForTruckStringBuilder.AppendLine(
$@"Dangerious materials:   {IsCarryingDangeriousMaterials}
Cargo volume:              {CargoVolume}");
            return detailsForTruckStringBuilder.ToString();
        }
    }
}
