using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        const int k_maxNumOfDoors = 5;
        const int k_minNUmOfDoors = 2;

        string m_colorOfCar;
        int m_numOfDoors;

        public Car(string colorOfCar, int numOfDoors, string licenseNumber, string modelName, Engine engineBase, List<Wheel> wheelsList) :
                base(licenseNumber, modelName, wheelsList, engineBase)
        {
            m_numOfDoors = numOfDoors;
            m_colorOfCar = colorOfCar;
        }

    }
}
