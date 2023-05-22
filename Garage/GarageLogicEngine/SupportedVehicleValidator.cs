﻿using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    class SupportedVehicleValidator
    {
        const string k_placeholderForString = "";
        const int k_placeholderInteger = -1;
        const bool k_placeholderIsCaryingDangeriousMaterials = true;
        const Motorcycle.eLicenseType k_placeholderLisenceType = Motorcycle.eLicenseType.A1;

        VehicleComponentFactory m_vehicleComponentFactory = new VehicleComponentFactory();
        List<Vehicle> m_SupportedVehicleInGarageList;
        
        public SupportedVehicleValidator()
        {
            Vehicle vehicle;

            vehicle = new Motorcycle(k_placeholderLisenceType, k_placeholderInteger, k_placeholderForString, k_placeholderForString, 2);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Octan98, 6.4f);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(2, k_placeholderForString, 31);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Motorcycle(k_placeholderLisenceType, k_placeholderInteger, k_placeholderForString, k_placeholderForString, 2);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Electricity, 2.6f);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(2, k_placeholderForString, 31);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Car(k_placeholderForString, 2, k_placeholderForString, k_placeholderForString, 5);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Octan95, 46);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(5, k_placeholderForString, 33);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Car(k_placeholderForString, 2, k_placeholderForString, k_placeholderForString, 5);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Electricity, 5.2f);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(5, k_placeholderForString, 33);
            m_SupportedVehicleInGarageList.Add(vehicle);

            vehicle = new Truck(k_placeholderIsCaryingDangeriousMaterials, k_placeholderInteger, k_placeholderForString, k_placeholderForString, 14);
            vehicle.Engine = m_vehicleComponentFactory.createEngine(Engine.eEnergyType.Soler, 135);
            vehicle.Wheels = m_vehicleComponentFactory.createWheelsCollection(14, k_placeholderForString, 26);
            m_SupportedVehicleInGarageList.Add(vehicle);
        }

        private bool compare()
        {

            return false;
        }
    }
}
