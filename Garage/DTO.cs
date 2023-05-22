using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public class EngineInformation
        {
            public Engine.eEnergyType m_EnergyType;
            public float m_currentEnergyCapacity;
            public float m_MaxEnergyCapacity;
        }


        public class WheelsSetInformation
        {
            public int m_numOfWheels;
            public string m_manufacturerName;
            public float m_maxPSI;
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
