using System.Collections;
using System.Collections.Generic;

using UnityEngine;


namespace UI.Score
{
    public class BallCountUIHandler : MonoBehaviour
    {
        public GameObject[] BallIcons = new GameObject[3];
        public GameObject[] StrikeIcons = new GameObject[2];
        public GameObject[] OutIcons = new GameObject[2];

        public BallCountManager BallCount;
        void Awake()
        {
            UpdateUI();
        }
        void OnEnable()
        {
            BallCount.OnUpdate += UpdateUI;
        }

        void OnDisable()
        {
            BallCount.OnUpdate -= UpdateUI;
        }

        private void UpdateUI()
        {
            for (int i = 0; i < 3; i++) {
                BallIcons[i].SetActive(i < BallCount.GetBallCount());
            }
            for(int i = 0; i < 2; i++)
            {
                StrikeIcons[i].SetActive(i < BallCount.GetStrikeCount());
                OutIcons[i].SetActive(i < BallCount.GetOutCount());
            }
        }
    }
}
