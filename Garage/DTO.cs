using static Ex03.GarageLogic.Motorcycle;

namespace Ex03.GarageLogic
{
    public enum AllowedVehicleTypes { Car, Motorcycle, Truck }

    public class DTO
    {
        public class VehicleInformation
        {
            public string m_modelName;
            public string m_licenseNumber;
            public int m_numOfWheels;
        }

        public class CarInformation
        {
            public string m_colorOfCar;
            public int m_numOfDoors;
        }

        public class TruckInformation
        {
            public bool m_isCarryingDangerousMaterials;
            public float m_maxCargoLoad;
        }

        public class MotorcycleInformation
        {
            public eLicenseType m_licenseType;
            public int m_engineVolume;
        }
    }
}
