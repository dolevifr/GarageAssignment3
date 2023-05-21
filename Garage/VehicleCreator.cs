﻿using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public enum AllowedVehicleTypes { Car, Motorcycle, Truck  }

    public class VehicleCreator
    {
        public class VehicleInformation
        {
            public string m_modelName;
            public string m_licenseNumber;
        }

        public class EngineInformation
        {
            public Engine.eEnergyType m_EnergyType;
            public float m_currentEnergyCapacity;
            public float m_MaxEnergyCapacity;
        }

        public class WheelsSetInformation
        {
            public int m_NumOfWheels;
            public string m_manufacturerName;
            public float m_maxPSI;
            public float m_initialPSI;
        }

        public class CarInformation
        {
            string m_colorOfCar;
            int m_numOfDoors;

        }

        private List<Wheel> createWheelsCollection(WheelsSetInformation wheelsSetInformation)
        {
            List<Wheel> wheelList= new List<Wheel>(wheelsSetInformation.m_NumOfWheels);
            
            for(int i = 0; i < wheelsSetInformation.m_NumOfWheels; i++)
            {
                wheelList.Add(new Wheel(wheelsSetInformation.m_manufacturerName, wheelsSetInformation.m_initialPSI, wheelsSetInformation.m_maxPSI));
            }

            return wheelList;
        }

        private Engine createElectricEngine(EngineInformation engineInformation)
        {
            return new ElectricEngine(engineInformation.m_MaxEnergyCapacity, engineInformation.m_currentEnergyCapacity);
        }

        private Engine createFuelEngine(EngineInformation engineInformation)
        {
            return new FuelEngine(engineInformation.m_EnergyType, engineInformation.m_MaxEnergyCapacity, engineInformation.m_currentEnergyCapacity);
        }

        private Engine createEngine(EngineInformation engineInformation)
        {
            Engine currentEngine;

            if (engineInformation.m_EnergyType == Engine.eEnergyType.Electricity)
            {
                currentEngine = createElectricEngine(engineInformation);
            }

            else
            {
                currentEngine = createFuelEngine(engineInformation);
            }
              
            return currentEngine;
        }


        private Vehicle CreateCarFromInfo(VehicleInformation vehicleInformation, EngineInformation engineInformation,
            WheelsSetInformation wheelsInformation, CarInformation carInformation)
        {
            List<Wheel> wheelsForVehicle = createWheelsCollection(wheelsInformation);
            Engine engineForVehicle = createEngine(engineInformation);

            return null;
        }
    }
}
