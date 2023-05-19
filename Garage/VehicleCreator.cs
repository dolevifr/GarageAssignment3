using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public enum AllowedVehicleTypes { Car, Motorcycle, Truck  }
    class VehicleCreator
    {
        public void CreateWheels(int i_NumOfWheels, string i_manufacturerName, int i_maxPSI, int i_initialPSI)
        {
            List<Wheel> wheelList= new List<Wheel>(i_NumOfWheels);
            
            for(int i = 0; i < i_NumOfWheels; i++)
            {
                wheelList.Add(new Wheel(i_manufacturerName, i_initialPSI, i_maxPSI));
            }

            return wheelList;
        }
    }
}
