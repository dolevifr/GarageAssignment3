using System;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private readonly string m_manufacturerName;
        private readonly float m_maxPSI;
        private float m_currentPSI = 0;

        public Wheel(string i_manufacturerName, float i_maxPSI)
        {
            m_manufacturerName = i_manufacturerName;
            m_maxPSI = i_maxPSI;
        }


        public string ManufacturerName
        {
            get { return m_manufacturerName; }
        }

        public float CurrentPSI
        {
            get { return m_currentPSI; }
        }

        public float MaxPSI
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
                throw new ValueOutOfRangeException(MaxPSI, 0);
            }
            else
            {
                m_currentPSI += airToFill;
            }
        }

        public string DisplayWheelDetail()
        {
            return String.Format($"Manufacturer: {ManufacturerName}, PSI: {CurrentPSI}/{MaxPSI}");
        }

    }
}
