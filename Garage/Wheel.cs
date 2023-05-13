using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Wheel
    {
        private string m_manufacturerName;
        private float m_currentPsi;
        private float m_maxPsi;
        
        private void airPump(int airToFill)
        { 
            if(airToFill + m_currentPsi > m_maxPsi)
            {
                System.Console.WriteLine("error");//need to add exception
            }
            else
            {
                m_currentPsi += airToFill;
            }
        }

        public string ManufacturerName
        {
            get { return m_manufacturerName; }
        }

        public float CurrentPsi
        { 
        get { return m_currentPsi;  }
        }

        public float MaxPsi
        {
            get { return m_maxPsi; }
        }

    }
}
