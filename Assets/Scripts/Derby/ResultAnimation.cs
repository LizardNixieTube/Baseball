using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Result
{
    public class ResultAnimation : MonoBehaviour
    {
        public VoidEvent AtBatResetEvent;

        private Animation m_ResultAnim;
        private Text m_ResultText;

        private void Start()
        {
            m_ResultAnim = GetComponent<Animation>();
            m_ResultText = GetComponent<Text>();
            m_ResultText.enabled = false;
        }

        public void DisplayResult(int state)
        {
            string anim_str = "GroundNFoulNStrikeUI";
            switch ((ResultState)state)
            {
                case ResultState.HR:
                    m_ResultText.text = "HOMERUN!!";
                    m_ResultText.color = Color.yellow;
                    anim_str = "HomeRunUI";
                    break;
                case ResultState.Foul:
                    m_ResultText.text = "FOUL";
                    m_ResultText.color = Color.green;
                    break;
                case ResultState.StrikeOut:
                    m_ResultText.text = "STRIKE";
                    m_ResultText.color = Color.red;
                    break;
                case ResultState.Ground:
                default:
                    m_ResultText.text = "GROUND BALL";
                    m_ResultText.color = Color.black;
                    break;
            }
            m_ResultText.enabled = true;
            m_ResultAnim.Play(anim_str);
        }
        public void OnAnimationFinisehd(string str)
        {
            m_ResultText.enabled = false;
            AtBatResetEvent.Raise();
        }
    }
}
