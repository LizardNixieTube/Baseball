using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Result
{
    public enum ResultState { StrikeOut, Ground, Foul, HR };
    
    public class ResultManager : MonoBehaviour
    {
        public Text MaxDistanceText;
        public Text TempDistanceText;
        public Text HRCountText;

        private uint m_HRCount = 0;
        private int m_MaxDistance = 0;
        private int m_Distance = 0;
        private ResultState m_CurrentResult = ResultState.Ground;

        public void Start()
        {
            MaxDistanceText.text = m_MaxDistance + "m";
            HRCountText.text = "" + m_HRCount;
        }

        public void UpdateHR(int result)
        {
            m_CurrentResult = (ResultState)result;
            
            if (m_CurrentResult == ResultState.HR)
            {
                HRCountText.text = "" + ++ m_HRCount;
            }
        }

        public void UpdateMaxDistance()
        {
            if(m_CurrentResult == ResultState.HR && m_Distance > m_MaxDistance)
            {
                m_MaxDistance = m_Distance;
                m_Distance = 0;
            }
            MaxDistanceText.text = Mathf.RoundToInt(m_MaxDistance) + "m";
            m_CurrentResult = ResultState.Ground;
        }

        public void UpdateDistance(float distance)
        {
            m_Distance = Mathf.RoundToInt(distance);
            TempDistanceText.text = m_Distance + "m";
        }

        public void Reset()
        {
            m_HRCount = 0;
            m_MaxDistance = 0;
        }
    }
}
