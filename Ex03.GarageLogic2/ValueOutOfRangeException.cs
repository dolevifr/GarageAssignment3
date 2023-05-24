using System;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        const string k_exceptionMessage = "Value is out of range, min value: {0}, max value: {1}"; 

        float m_maxValue;
        float m_minValue;

        public ValueOutOfRangeException(float i_maxValue, float i_minValue) : base(String.Format(k_exceptionMessage, i_minValue, i_maxValue))
        {
            m_minValue = i_minValue;
            m_maxValue = i_maxValue;
        }
    }
}
