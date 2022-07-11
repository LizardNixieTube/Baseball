using UnityEngine;
using UnityEngine.Events;

namespace UI.Score
{
    [CreateAssetMenu(fileName="New BallCountManager",menuName="Manager/BallCount")]
    public class BallCountManager : ScriptableObject
    {
        public UnityAction OnUpdate;
        
        private int m_CurrentBallCount = 0;
        private int m_CurrentStrikeCount = 0;
        private int m_CurrentOutCount = 0;

        private const int MAX_BALL_COUNT = 3;
        private const int MAX_STRIKE_COUNT = 2;
        private const int MAX_OUT_COUNT = 2;

        public int GetBallCount()
        {
            return m_CurrentBallCount;
        }

        public int GetStrikeCount()
        {
            return m_CurrentStrikeCount;
        }
        public int GetOutCount()
        {
            return m_CurrentOutCount;
        }

        public void IncrementCount(bool isStrike)
        {
            Debug.Log("Ball Count: " + isStrike);
            if (isStrike)
            {
                 if(++m_CurrentStrikeCount > MAX_STRIKE_COUNT)
                 {
                     m_CurrentStrikeCount = 0;
                    if (++m_CurrentOutCount > MAX_OUT_COUNT)
                    {
                        m_CurrentOutCount = 0;
                    }
                }
            }
            else if(++m_CurrentBallCount > MAX_BALL_COUNT)
            {
                m_CurrentBallCount = 0;
            }

            Debug.Log("STRIKE: " + m_CurrentStrikeCount);
            Debug.Log("BALL:   " + m_CurrentBallCount);
            Debug.Log("OUT:    " + m_CurrentOutCount);
            OnUpdate.Invoke();
        }

        public void Reset()
        {
            m_CurrentBallCount = 0;
            m_CurrentStrikeCount = 0;
            m_CurrentOutCount = 0;
        }
    }
}