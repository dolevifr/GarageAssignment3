using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public enum AllowedVehicleTypes { Car, Motorcycle, Truck  }

    public class VehicleCreator
    {
        private List<Wheel> createWheelsCollection(DTO.WheelsSetInformation i_wheelsSetInformation)
        {
            List<Wheel> wheelList= new List<Wheel>(i_wheelsSetInformation.m_NumOfWheels);
            
            for(int i = 0; i < i_wheelsSetInformation.m_NumOfWheels; i++)
            {
                wheelList.Add(new Wheel(i_wheelsSetInformation.m_manufacturerName, i_wheelsSetInformation.m_initialPSI, i_wheelsSetInformation.m_maxPSI));
            }

            return wheelList;
        }


        private Engine createEngine(DTO.EngineInformation i_engineInformation)
        {
            Engine currentEngine;

            if (i_engineInformation.m_EnergyType == Engine.eEnergyType.Electricity)
            {
                currentEngine = new ElectricEngine(i_engineInformation.m_MaxEnergyCapacity, i_engineInformation.m_currentEnergyCapacity);
            }
            else
            {
                currentEngine = new FuelEngine(i_engineInformation.m_EnergyType, i_engineInformation.m_MaxEnergyCapacity, i_engineInformation.m_currentEnergyCapacity);
            }
              
            return currentEngine;
        }


        private Vehicle CreateCarFromInfo(DTO.VehicleInformation i_vehicleInformation, DTO.EngineInformation i_engineInformation,
            DTO.WheelsSetInformation i_wheelsInformation, DTO.CarInformation i_carInformation)
        {
            List<Wheel> wheelsForVehicle = createWheelsCollection(i_wheelsInformation);
            Engine engineForVehicle = createEngine(i_engineInformation);

            return new Car(i_carInformation.m_colorOfCar, i_carInformation.m_numOfDoors,
                            i_vehicleInformation.m_licenseNumber, i_vehicleInformation.m_modelName,
                            engineForVehicle, wheelsForVehicle);
        }

        private Vehicle CreateMotorCycleFromInfo(DTO.VehicleInformation i_vehicleInformation, DTO.EngineInformation i_engineInformation,
            DTO.WheelsSetInformation i_wheelsInformation, DTO.MotorcycleInformation i_motorcycleInformation)
        {
            List<Wheel> wheelsForVehicle = createWheelsCollection(i_wheelsInformation);
            Engine engineForVehicle = createEngine(i_engineInformation);

            return new Motorcycle(i_motorcycleInformation.m_licenseType, i_motorcycleInformation.m_engineVolume,
                i_vehicleInformation.m_licenseNumber, i_vehicleInformation.m_modelName,
                engineForVehicle, wheelsForVehicle);
        }

        private Vehicle CreateTruckFromInfo(DTO.VehicleInformation vehicleInformation, DTO.EngineInformation engineInformation,
            DTO.WheelsSetInformation wheelsInformation, DTO.TruckInformation truckInformation)
        {
            List<Wheel> wheelsForVehicle = createWheelsCollection(wheelsInformation);
            Engine engineForVehicle = createEngine(engineInformation);

            return new Truck(truckInformation.m_isCarryingDangerousMaterials, truckInformation.m_maxCargoLoad,
                vehicleInformation.m_licenseNumber, vehicleInformation.m_modelName,
                engineForVehicle, wheelsForVehicle);
        }
    }
}
