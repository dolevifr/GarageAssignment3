using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Vehicle
    {
        string m_modelName;
        string m_licenseNumber;
        float m_energyPercentageLeft;
        Wheel m_wheelBase;
        Engine m_engineBase;

        private void addEnergyToVehicle(float energyToAdd)
        {
            if(m_energyPercentageLeft + energyToAdd > 100)
            {
                System.Console.WriteLine("error"); // need to add exception
            }
            else
            {
                m_energyPercentageLeft += energyToAdd;
            }
        }
    }
}
