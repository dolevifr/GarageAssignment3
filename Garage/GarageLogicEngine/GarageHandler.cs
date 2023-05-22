using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class GarageHandler
    {
        private Dictionary<string, VehicleInformation> vehiclesInTheGarage = new Dictionary<string, VehicleInformation>();

        private class VehicleInformation
        {
            public Vehicle m_Vehicle;
            public eVehicleStatus m_VehicleStaus;
            public string m_OwnerName;
            public string m_OwnerPhoneNumber;

            public string GetVehicleDetails(string i_licenseNumber)
            {
                return string.Format(
                $@"License Name:   {m_Vehicle.LicenseNumber}
                   Model Name:     {m_Vehicle.ModelName}
                   Owner Name      {m_OwnerName}
                   Vehicle Status  {m_VehicleStaus}");
            }
        }

        public enum eVehicleStatus { InRepair, Repaird, Paid }

        public void InsertVehicleToGarage(Vehicle i_vehicleToInsert, string i_ownerName, string i_ownerPhoneNumber)
        {
            VehicleInformation vehicleInformation = new VehicleInformation();
            vehicleInformation.m_Vehicle = i_vehicleToInsert;
            vehicleInformation.m_OwnerName = i_ownerName;
            vehiclesInTheGarage.Add(i_vehicleToInsert.LicenseNumber, vehicleInformation);
        }

        public bool IsVehicleInGarage(string i_licenseNumber)
        {
            return vehiclesInTheGarage.ContainsKey(i_licenseNumber);
        }

        public string GetAllLicenseNumbersInGarage(eVehicleStatus? vehicleStatusToFilterBy = null)
        {
            StringBuilder licenseIDsInGarage = new StringBuilder();

            foreach (VehicleInformation vehicleInfo in vehiclesInTheGarage.Values)
            {
                if ((vehicleStatusToFilterBy.HasValue && vehicleInfo.m_VehicleStaus == vehicleStatusToFilterBy) || !vehicleStatusToFilterBy.HasValue)
                    licenseIDsInGarage.AppendLine(vehicleInfo.m_Vehicle.LicenseNumber);
            }

            return licenseIDsInGarage.ToString();
        }

        public void ChangeVehicleStatus(string i_licenseNumberOfVehicle, eVehicleStatus i_newVehicleStatus)
        {
            vehiclesInTheGarage[i_licenseNumberOfVehicle].m_VehicleStaus = i_newVehicleStatus;
        }

        public void RefuelVehicle(string i_licenseNumberOfVehicle, Engine.eEnergyType i_fuelType, float i_FuelToAddLiters)
        {
            Vehicle currentVehicle = vehiclesInTheGarage[i_licenseNumberOfVehicle].m_Vehicle;
            currentVehicle.AddEnergy(i_FuelToAddLiters, i_fuelType);
        }

        public void RechargeVehicle(string i_licenseNumberOfVehicle, float i_energyAmountToAdd)
        {
            Vehicle currentVehicle = vehiclesInTheGarage[i_licenseNumberOfVehicle].m_Vehicle;
            currentVehicle.AddEnergy(i_energyAmountToAdd, Engine.eEnergyType.Electricity);
        }
    }
}
