using Ex03.GarageLogic;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class GarageLogicEngine
    {
        VehicleComponentFactory m_VehicleComponentFactory = new VehicleComponentFactory();
        VehicleFactory m_VehicleFactory = new VehicleFactory();
        GarageHandler m_GarageHandler = new GarageHandler();
        Vehicle m_CurrentVehicle = null;

        bool m_isEngineAdded = false;
        bool m_areWheelsAdded = false;


        public void AddVehicleToGarage(string i_ownerName, string i_ownerPhoneNumber)
        {
            m_GarageHandler.InsertVehicleToGarage(m_CurrentVehicle, i_ownerName, i_ownerPhoneNumber);
        }

        public void AddEngineToCurrentCar(Engine.eEnergyType i_EnergyType, float m_MaxEnergyCapacity)
        {
            m_CurrentVehicle.Engine = m_VehicleComponentFactory.createEngine(i_EnergyType, m_MaxEnergyCapacity);
            m_isEngineAdded = true;
        }

        public void AddWheelsToCurrentCar(int i_numOfWheels, string i_manufacturerName, int i_maxPSI)
        {
            m_CurrentVehicle.Wheels = m_VehicleComponentFactory.createWheelsCollection(i_numOfWheels, i_manufacturerName, i_maxPSI);
            m_areWheelsAdded = true;
        }

        public bool isVehicleExistsInGarage(string i_licenseNumberOfVehicle)
        {
            return m_GarageHandler.IsVehicleInGarage(i_licenseNumberOfVehicle);
        }

        public string getVehicleInfo(string i_licenseNumberOfVehicle)
        {
            return m_GarageHandler.getVehicleDetails(i_licenseNumberOfVehicle);
        }

        public string GetAllLicenseNumbersInGarage(GarageHandler.eVehicleStatus? vehicleStatusToFilterBy = null)
        {
            return m_GarageHandler.GetAllLicenseNumbersInGarage(vehicleStatusToFilterBy);
        }
    }
}
