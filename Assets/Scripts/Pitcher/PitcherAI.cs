using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Pitcher {
    public class PitcherAI : MonoBehaviour
    {
        public UnityAction<Vector2> PitchSelectActions;
        public UnityAction          PitchConfirmActions;
        public UnityAction<Vector2> PitchCursorActions;

        enum State { IDLE, PICKING, THROWING, CLOSING };

        private State m_CurrentState = State.IDLE;
        [SerializeField] private float m_WaitTime = 5.0f;
        private float m_Time = 0.0f;
        private bool isReady;

        // Update is called once per frame
        void Update()
        {
            /*
             *Way to override the control of the pitcher
             *
             *1. Wait for the ready signal from the game
             * 2. Randomly select the pitchtype (weighted?)
             * 3. select the throwing location
             */
            switch (m_CurrentState)
            {
                case State.IDLE:
                    if (m_Time > m_WaitTime)
                    {
                        m_CurrentState = State.PICKING;
                        m_Time = 0.0f;
                    }
                    else
                    {
                        m_Time += Time.deltaTime;
                    }
                    break;
                case State.PICKING:
                    SelectNConfirm();
                    m_CurrentState = State.THROWING;
                    break;
                case State.THROWING:
                    CursorMove();
                    break;
                case State.CLOSING:
                    //wait for the response from the other part of the game for pitch to start to throw

                    //TEMP - just back to idle for now
                    m_CurrentState = State.IDLE;
                    break;
            }
        }

        public void Throwed()
        {
            m_CurrentState = State.CLOSING;
        }

        private void SelectNConfirm()
        {
            //Randomly select the pitch
            Vector2 selected = new Vector2(Mathf.RoundToInt(Random.value * 2 - 1), Mathf.RoundToInt(Random.value * 2 - 1));
            //Invoke actions
            if(PitchConfirmActions != null && PitchSelectActions != null)
            {
                PitchSelectActions.Invoke(selected);
                PitchConfirmActions.Invoke();
            }
        }

        private void CursorMove()
        {
            if(PitchCursorActions != null)
            {
                Vector2 dir = new Vector2(Random.value* 2 - 1, Random.value * 2 - 1 );
                PitchCursorActions.Invoke(dir);
            }
        }
    }

}