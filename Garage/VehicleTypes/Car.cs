using System.Collections.Generic;

﻿namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        const int k_maxNumOfDoors = 5;
        const int k_minNUmOfDoors = 2;

        string m_colorOfCar;
        int m_numOfDoors;

        public Car(string colorOfCar, int numOfDoors, string licenseNumber, string modelName, int i_numOfWheels) :
                base(licenseNumber, modelName, i_numOfWheels)
        {
            if(k_minNUmOfDoors < numOfDoors || numOfDoors > k_maxNumOfDoors)
            {
                //throw exception
            }

            m_numOfDoors = numOfDoors;
            m_colorOfCar = colorOfCar;
        }

        public string Color
        {
            get { return m_colorOfCar; }
        }

        public int DoorsNumber
        {
            get { return m_numOfDoors; }
        }

    }
}
