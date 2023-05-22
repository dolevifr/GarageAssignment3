using System.Collections.Generic;

﻿namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        const int k_maxNumOfDoors = 5;
        const int k_minNUmOfDoors = 2;

        string m_colorOfCar;
        int m_numOfDoors;

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
                    //throw exception
                }

                m_numOfDoors = value; 
            }
        }

    }
}
