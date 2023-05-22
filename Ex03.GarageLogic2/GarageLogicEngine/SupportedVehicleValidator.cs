using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    class SupportedVehicleValidator
    {
        private const string k_placeholderForString = "";

        private readonly VehicleComponentFactory m_vehicleComponentFactory = new VehicleComponentFactory();
        private readonly List<Vehicle> m_SupportedVehicleInGarageList = new List<Vehicle>();


        public SupportedVehicleValidator()
        {
            initializeListOfSupportedVehicles();
        }

        public bool IsVehicleSupportedInGarage(Vehicle i_vehicle)
        {
            bool isVehicleSupported = false;

            foreach(Vehicle serviceableVehicle in m_SupportedVehicleInGarageList)
            {
                if (compareVehicles(serviceableVehicle, i_vehicle))
                {
                    isVehicleSupported = true;
                    break;
                }
            }

            return isVehicleSupported;
        }

        private static bool compareVehicles(Vehicle i_vehicle1, Vehicle i_vehicle2)
        {
            bool sameWheelsNumber = i_vehicle1.WheelsNum == i_vehicle2.WheelsNum;
            bool sameMaxPSIForWheels = i_vehicle1.MaxPSI == i_vehicle2.MaxPSI;
            bool sameFuelType = i_vehicle1.EngineType == i_vehicle2.EngineType;
            bool maxEnergyCapacity = i_vehicle1.MaxEngineCapacity == i_vehicle2.MaxEngineCapacity;

            return sameWheelsNumber && sameMaxPSIForWheels && sameFuelType && maxEnergyCapacity;
        }

        private void initializeListOfSupportedVehicles()
        {
            Vehicle vehicle;

            vehicle = new Motorcycle(k_placeholderForString, k_placeholderForString, 2);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Octan98, 6.4f);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(2, k_placeholderForString, 31);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Motorcycle(k_placeholderForString, k_placeholderForString, 2);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Electricity, 2.6f);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(2, k_placeholderForString, 31);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Car(k_placeholderForString, k_placeholderForString, 5);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Octan95, 46);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(5, k_placeholderForString, 33);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Car(k_placeholderForString, k_placeholderForString, 5);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Electricity, 5.2f);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(5, k_placeholderForString, 33);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Truck(k_placeholderForString, k_placeholderForString, 14);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Soler, 135);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(14, k_placeholderForString, 26);
            m_SupportedVehicleInGarageList.Add(vehicle);
        }
    }
}
