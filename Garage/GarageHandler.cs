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
            string m_OwnerName;
            string m_OwnerPhoneNumber;
            eVehicleStatus m_VehicleStaus;
        }
        enum eVehicleStatus { InRepair, Repaird, Paid }

        void InsertVehicleToGarage(VehicleInformation i_vehicleToInsert)
        {

            vehiclesInTheGarage.Add(i_vehicleToInsert.m_Vehicle.LicenseNumber, i_vehicleToInsert);
        }



        void changeVehicleStatus()
        {

        }

    }
}
