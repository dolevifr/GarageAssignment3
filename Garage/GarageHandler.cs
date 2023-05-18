using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class GarageHandler
    {
        private Dictionary<string, VehicleInformation> vehiclesInTheGarage = new Dictionary<string, VehicleInformation>();

        private struct VehicleInformation
        {
            public Vehicle m_Vehicle;
            public string m_OwnerName;
            public string m_OwnerPhoneNumber;
            eVehicleStatus m_VehicleStaus;
        }
        enum eVehicleStatus { InRepair, Repaird, Paid }

        void InsertVehicleToGarage(Vehicle i_vehicleToInsert,string i_ownerName, string i_ownerPhoneNumber)
        {
            VehicleInformation vehicleInformation = new VehicleInformation();
            vehicleInformation.m_Vehicle = i_vehicleToInsert;
            vehicleInformation.m_OwnerName = i_ownerName;
            vehiclesInTheGarage.Add(i_vehicleToInsert.LicenseNumber, vehicleInformation);
        }
        
        bool isVehicleInGarage(string licenseNumber)
        {
            return vehiclesInTheGarage.ContainsKey(licenseNumber);
        }




        void changeVehicleStatus()
        {

        }

    }
}
