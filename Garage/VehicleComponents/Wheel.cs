using System;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_manufacturerName;
        private float m_currentPSI = 0;
        private float m_maxPSI;

        public Wheel(string i_manufacturerName, float i_maxPSI)
        {
            m_manufacturerName = i_manufacturerName;
            m_maxPSI = i_maxPSI;
        }


        public string ManufacturerName
        {
            get { return m_manufacturerName; }
        }

        public float CurrentPsi
        {
            get { return m_currentPSI; }
        }

        public float MaxPsi
        {
            get { return m_maxPSI; }
        }

        public void FillToMaxAirPressur()
        {
            m_currentPSI = m_maxPSI;
        }

        private void pumpAirToWheel(int airToFill)
        {
            if (airToFill + m_currentPSI > m_maxPSI)
            {
                Console.WriteLine("error");//need to add exception
            }
            else
            {
                m_currentPSI += airToFill;
            }
        }

    }
}
