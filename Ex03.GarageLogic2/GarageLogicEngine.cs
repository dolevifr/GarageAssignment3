using System;

namespace Ex03.GarageLogic
{
    public class GarageLogicEngine
    {
        private readonly VehicleComponentFactory m_VehicleComponentFactory = new VehicleComponentFactory();
        private readonly VehicleFactory m_VehicleFactory = new VehicleFactory();
        private readonly GarageHandler m_GarageHandler = new GarageHandler();
        private Vehicle  m_CurrentVehicle = null;

        private bool m_isEngineAdded = false;
        private bool m_areWheelsAdded = false;


        public void CreateVehicle(VehicleFactory.AllowedVehicleTypes i_carTypeToCreate, string i_licenseNumber, string i_carModelName, int i_numOfWheels)
        {
            m_CurrentVehicle = m_VehicleFactory.CreateVehicle(i_carTypeToCreate, i_licenseNumber, i_carModelName, i_numOfWheels);
            m_isEngineAdded = false;
            m_areWheelsAdded = false;
        }

        public void AddVehicleToGarage(string i_ownerName, string i_ownerPhoneNumber)
        {
            if (!m_areWheelsAdded || !m_isEngineAdded)
            {
                throw new MissingFieldException("No wheels or engine was added to current vehicle");
            }

            m_GarageHandler.InsertVehicleToGarage(m_CurrentVehicle, i_ownerName, i_ownerPhoneNumber);
        }

        public void AddEngineToCurrentCar(Engine.eEnergyType i_EnergyType, float i_MaxEnergyCapacity)
        {
            m_CurrentVehicle.Engine = m_VehicleComponentFactory.CreateEngine(i_EnergyType, i_MaxEnergyCapacity);
            m_isEngineAdded = true;
        }

        public void AddWheelsToCurrentCar(int i_numOfWheels, string i_manufacturerName, int i_maxPSI)
        {
            m_CurrentVehicle.Wheels = m_VehicleComponentFactory.CreateWheelsCollection(i_numOfWheels, i_manufacturerName, i_maxPSI);
            m_areWheelsAdded = true;
        }

        public bool IsVehicleExistsInGarage(string i_licenseNumberOfVehicle)
        {
            return m_GarageHandler.IsVehicleInGarage(i_licenseNumberOfVehicle);
        }

        public string GetAllLicenseNumbersInGarage(GarageHandler.eVehicleStatus? i_vehicleStatusToFilterBy = null)
        {
            return m_GarageHandler.GetAllLicenseNumbersInGarage(i_vehicleStatusToFilterBy);
        }

        public string GetVehicleDetails(string i_licenseNumberOfVehicle)
        {
            return m_GarageHandler.GetVehicleDetails(i_licenseNumberOfVehicle);
        }

        public void ChangeVehicleStatus(string i_licenseNumberOfVehicle, GarageHandler.eVehicleStatus i_newVehicleStatus)
        {
            m_GarageHandler.ChangeVehicleStatus(i_licenseNumberOfVehicle, i_newVehicleStatus);
        }

        public void FillMaxPSIWheels(string i_licenseNumberOfVehicle)
        {
            m_GarageHandler.FeelVehicleWheelsToMaxPSI(i_licenseNumberOfVehicle);
        }

        public void RechargeVehicle(string i_licenseNumberOfVehicle, float i_energyAmountToAdd)
        {
            m_GarageHandler.RechargeVehicle(i_licenseNumberOfVehicle, i_energyAmountToAdd);
        }

        public void RefuelVehicle(string i_licenseNumberOfVehicle, Engine.eEnergyType i_fuelType, float i_FuelToAddLiters)
        {
            m_GarageHandler.RefuelVehicle(i_licenseNumberOfVehicle, i_fuelType, i_FuelToAddLiters);
        }

        public void InitializeEnergyInVehicle(Engine.eEnergyType i_fuelType, float i_FuelToAddLiters)
        {
            m_CurrentVehicle.AddEnergy(i_FuelToAddLiters, i_fuelType);
        }

        public void InitializePSIInVehicle(float i_PSIToAdd)
        {
            m_CurrentVehicle.PumpAllWheelsInVehicle(i_PSIToAdd);
        }

        public void AddUniqueFieldsForCar(int i_numOfDoors, string i_color)
        {
            Car car = m_CurrentVehicle as Car;
            
            if(car == null)
            {
                throw new ArgumentException("License ID does not belong to a vehicle");
            }

            car.Color = i_color;
            car.DoorsNumber = i_numOfDoors;
        }

        public void AddUniqueFieldsForMotorcycle(Motorcycle.eLicenseType i_licenseType, int i_engineVolume)
        {
            Motorcycle motorcycle = m_CurrentVehicle as Motorcycle;
            if (motorcycle == null)
            {
                {
                    throw new ArgumentException("License ID does not belong to a vehicle");
                }
            }

            motorcycle.EngineVolume = i_engineVolume;
            motorcycle.LicenseType = i_licenseType;
        }

        public void AddUniqueFieldsForTruck(bool m_isCarryingDangerousMaterials, float m_cargoVolume)
        {
            Truck truck = m_CurrentVehicle as Truck;

            if (truck == null)
            {
                throw new ArgumentException("License ID does not belong to a car");
            }

            truck.IsCarryingDangeriousMaterials = m_isCarryingDangerousMaterials;
            truck.CargoVolume = m_cargoVolume;
        }
    }
}
