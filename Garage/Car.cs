using Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Car : Vehicle
    {
        string m_colorOfCar;
        int m_numOfDoors;

        public Car(string licenseNumber, string modelName, Engine engineBase, string colorOfCar, int numOfDoors) :
                base(licenseNumber, modelName, engineBase)
        {
            m_numOfDoors = numOfDoors;
            m_colorOfCar = colorOfCar;
        }
    }
}
