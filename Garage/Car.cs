namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        const int k_maxNumOfDoors = 5;
        const int k_minNUmOfDoors = 2;

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
