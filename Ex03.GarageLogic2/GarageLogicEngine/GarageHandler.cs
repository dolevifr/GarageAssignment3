using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class GarageHandler
    {
        private readonly Dictionary<string, VehicleInformation> m_vehiclesInTheGarage = new Dictionary<string, VehicleInformation>();
        private SupportedVehicleValidator m_supportedVehicleValidator = new SupportedVehicleValidator();
        private class VehicleInformation
        {
            public Vehicle m_Vehicle;
            public eVehicleStatus m_VehicleStaus;
            public string m_OwnerName;
            public string m_OwnerPhoneNumber;

            public string GetVehicleDetails()
            {
                return string.Format(
$@"License Name:   {m_Vehicle.LicenseNumber}
Owner Name      {m_OwnerName}
Vehicle Status  {m_VehicleStaus}
{m_Vehicle.DisplayDetails()}");
            }
        }

        public enum eVehicleStatus { InRepair, Repaird, Paid }

        public void InsertVehicleToGarage(Vehicle i_vehicleToInsert, string i_ownerName, string i_ownerPhoneNumber)
        {
            if (!m_supportedVehicleValidator.IsVehicleSupportedInGarage(i_vehicleToInsert))
            {
                throw new ArgumentException("Vehicle is not supported by the garage");
            }


            VehicleInformation vehicleInformation = new VehicleInformation();
            vehicleInformation.m_Vehicle = i_vehicleToInsert;
            vehicleInformation.m_OwnerName = i_ownerName;
            vehicleInformation.m_OwnerPhoneNumber = i_ownerPhoneNumber;
            m_vehiclesInTheGarage.Add(i_vehicleToInsert.LicenseNumber, vehicleInformation);
        }

        public bool IsVehicleInGarage(string i_licenseNumber)
        {
            return m_vehiclesInTheGarage.ContainsKey(i_licenseNumber);
        }

        public string GetAllLicenseNumbersInGarage(eVehicleStatus? vehicleStatusToFilterBy = null)
        {
            StringBuilder licenseIDsInGarage = new StringBuilder();

            foreach (VehicleInformation vehicleInfo in m_vehiclesInTheGarage.Values)
            {
                if ((vehicleStatusToFilterBy.HasValue && vehicleInfo.m_VehicleStaus == vehicleStatusToFilterBy) || !vehicleStatusToFilterBy.HasValue)
                    licenseIDsInGarage.AppendLine(vehicleInfo.m_Vehicle.LicenseNumber);
            }

            return licenseIDsInGarage.ToString();
        }

        public void ChangeVehicleStatus(string i_licenseNumberOfVehicle, eVehicleStatus i_newVehicleStatus)
        {
            m_vehiclesInTheGarage[i_licenseNumberOfVehicle].m_VehicleStaus = i_newVehicleStatus;
        }

        public void RefuelVehicle(string i_licenseNumberOfVehicle, Engine.eEnergyType i_fuelType, float i_FuelToAddLiters)
        {
            Vehicle currentVehicle = m_vehiclesInTheGarage[i_licenseNumberOfVehicle].m_Vehicle;
            currentVehicle.AddEnergy(i_FuelToAddLiters, i_fuelType);
        }

        public void RechargeVehicle(string i_licenseNumberOfVehicle, float i_energyAmountToAdd)
        {
            Vehicle currentVehicle = m_vehiclesInTheGarage[i_licenseNumberOfVehicle].m_Vehicle;
            currentVehicle.AddEnergy(i_energyAmountToAdd, Engine.eEnergyType.Electricity);
        }

        public string GetVehicleDetails(string i_licenseNumberOfVehicle)
        {
            if (!IsVehicleInGarage(i_licenseNumberOfVehicle))
            {
                throw new ArgumentException("No vehicle with license number given exists in garage.");
            }

            return m_vehiclesInTheGarage[i_licenseNumberOfVehicle].GetVehicleDetails();
        }
    }
}
