using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pitcher
{
    public class BallSelect : MonoBehaviour
    {
        private bool m_IsAI = true;

        public PitcherInputReader InputReader;
        public PitcherAI AIReader;

        public Text DisplayText;

        public PitcherDataSO PitcherData;

        private Dictionary<BallDir, GameObject>  m_PitchArrowUIDict = new Dictionary<BallDir, GameObject>();
        private Dictionary<BallDir, PitchTypeSO> m_PitchTypeDict    = new Dictionary<BallDir, PitchTypeSO>();

        private BallDir m_SelectedBallDir;

        public PitchConfirmEvent _OnConfirmPitchEvent;

        public void OnEnable()
        {
            m_IsAI = true;
            if (m_IsAI)
            {
                AIReader.PitchSelectActions += Select;
                AIReader.PitchConfirmActions += Confirm;
            }
            else
            {
                InputReader.SelectActions += Select;
                InputReader.ConfirmActions += Confirm;
                DisplayText.enabled = true;
            } 
        }

        public void OnDisable()
        {
            InputReader.SelectActions  -= Select;
            InputReader.ConfirmActions -= Confirm;
            AIReader.PitchSelectActions -= Select;
            AIReader.PitchConfirmActions -= Confirm;
            DisplayText.enabled = false;
        }

        public void Override(bool isAI) { m_IsAI = isAI; }

        public void Start()
        {
         /**
          * for all the child(arrow) in the UI, if the pitcher has a breakball in the
          * arrow direction, set the arrow active and add it to the dictionary
          **/
            for (int i = 0; i < transform.childCount; ++i)
            {
                GameObject arrowUI = transform.GetChild(i).gameObject;
                ArrowDirection arrowDir = arrowUI.GetComponent<ArrowDirection>();

                arrowUI.SetActive(false); //disable in-case there aren't available
   
                //TODO - ASSERTION

                //Loop through pitchtypes (ïœâªãÖÅjthe pitcher is available to determine which arrow to display
                foreach (PitchTypeSO pitchType in PitcherData.PitchTypes)
                {
                    //if it match with arrow
                    if (arrowDir.Dir == pitchType.Dir)
                    {
                        //active the gameObj(arrow)
                        arrowUI.SetActive(true);
                        //add to dictionary
                        if(!m_PitchTypeDict.ContainsKey(arrowDir.Dir))     m_PitchTypeDict.Add(arrowDir.Dir, pitchType);
                        if(!m_PitchArrowUIDict.ContainsKey(arrowDir.Dir)) m_PitchArrowUIDict.Add(arrowDir.Dir, arrowUI);
                        break;
                    }
                }
            }
            //Default SLOW Ball
            m_SelectedBallDir = BallDir.SLOW;
            SelectBall(BallDir.SLOW);
        }

        public void SelectBall(BallDir dir)
        {
            m_PitchArrowUIDict[m_SelectedBallDir].GetComponent<Image>().color = Color.white;
            
            if (m_PitchArrowUIDict.ContainsKey(dir))
            {
                m_SelectedBallDir = dir;
            }  
            else
            {
                m_SelectedBallDir = BallDir.SLOW;
            }

            m_PitchArrowUIDict[m_SelectedBallDir].GetComponent<Image>().color = Color.red;
            DisplayText.text = m_PitchTypeDict[m_SelectedBallDir].Name;
        }
        private void Select(Vector2 dir)
        {
            SelectBall(PitchTypeSO.WhatBallType(dir));
        }

        private void Confirm()
        {
            PitchTypeSO selectedType = m_PitchTypeDict[m_SelectedBallDir];

            _OnConfirmPitchEvent.Raise(selectedType);

            gameObject.SetActive(false);
        }
    }
}