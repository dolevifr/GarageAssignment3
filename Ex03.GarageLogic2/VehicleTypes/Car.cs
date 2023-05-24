using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        const int k_maxNumOfDoors = 5;
        const int k_minNUmOfDoors = 2;

        private string m_colorOfCar;
        private int m_numOfDoors;

        public Car(string licenseNumber, string modelName, int i_numOfWheels) :
                base(licenseNumber, modelName, i_numOfWheels) {}

        public string Color
        {
            get { return m_colorOfCar; }
            set { m_colorOfCar = value; }
        }

        public int DoorsNumber
        {
            get 
            { 
                return m_numOfDoors; 
            }
            set 
            {
                if (k_minNUmOfDoors < value || value > k_maxNumOfDoors)
                {
                    throw new ValueOutOfRangeException(k_maxNumOfDoors, k_minNUmOfDoors);
                }

                m_numOfDoors = value; 
            }
        }

        public override string DisplayDetails()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(base.DisplayDetails());
            s.AppendLine(
$@"Color:          {Color}
Doors number:      {DoorsNumber}"
);
            return s.ToString();
        }

    }
}
