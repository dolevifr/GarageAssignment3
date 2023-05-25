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
            private Vehicle m_Vehicle;
            private eVehicleStatus m_VehicleStaus;
            private string m_OwnerName;
            private string m_OwnerPhoneNumber;

            public Vehicle Vehicle
            {
                get { return m_Vehicle; }
                set { m_Vehicle = value; }
            }

            public eVehicleStatus VehicleStatus
            {
                get { return m_VehicleStaus; }
                set { m_VehicleStaus = value; }
            }

            public string OwnerName {
                get { return m_OwnerName; }
                set { m_OwnerName = value; }
            }

            public string OwnerPhoneNumber
            {
                get { return m_OwnerPhoneNumber; }
                set { m_OwnerPhoneNumber = value; }
            }

            public string GetVehicleDetails()
            {
                return string.Format(
$@"License Name:    {m_Vehicle.LicenseNumber}
Owner Name          {m_OwnerName}
Owner Phoine Number {m_OwnerPhoneNumber}
Vehicle Status      {m_VehicleStaus}

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
            vehicleInformation.Vehicle = i_vehicleToInsert;
            vehicleInformation.OwnerName = i_ownerName;
            vehicleInformation.OwnerPhoneNumber = i_ownerPhoneNumber;
            m_vehiclesInTheGarage.Add(i_vehicleToInsert.LicenseNumber, vehicleInformation);
        }

        public bool IsVehicleInGarage(string i_licenseNumber)
        {
            return m_vehiclesInTheGarage.ContainsKey(i_licenseNumber);
        }

        public string GetAllLicenseNumbersInGarage(eVehicleStatus? i_vehicleStatusToFilterBy = null)
        {
            StringBuilder licenseIDsInGarage = new StringBuilder();

            foreach (VehicleInformation vehicleInfo in m_vehiclesInTheGarage.Values)
            {
                if ((i_vehicleStatusToFilterBy.HasValue && vehicleInfo.VehicleStatus == i_vehicleStatusToFilterBy)
                    || !i_vehicleStatusToFilterBy.HasValue)
                {
                    licenseIDsInGarage.AppendLine(vehicleInfo.Vehicle.LicenseNumber);
                }
            }

            return licenseIDsInGarage.ToString();
        }

        public void ChangeVehicleStatus(string i_licenseNumberOfVehicle, eVehicleStatus i_newVehicleStatus)
        {
            m_vehiclesInTheGarage[i_licenseNumberOfVehicle].VehicleStatus = i_newVehicleStatus;
        }

        public void RefuelVehicle(string i_licenseNumberOfVehicle, Engine.eEnergyType i_fuelType, float i_FuelToAddLiters)
        {
            Vehicle currentVehicle = m_vehiclesInTheGarage[i_licenseNumberOfVehicle].Vehicle;
            currentVehicle.AddEnergy(i_FuelToAddLiters, i_fuelType);
        }

        public void FeelVehicleWheelsToMaxPSI(string i_licenseNumberOfVehicle)
        {
            m_vehiclesInTheGarage[i_licenseNumberOfVehicle].Vehicle.FillAllTiresToMaxPSI();
        }

        public void RechargeVehicle(string i_licenseNumberOfVehicle, float i_energyAmountToAdd)
        {
            Vehicle currentVehicle = m_vehiclesInTheGarage[i_licenseNumberOfVehicle].Vehicle;
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
