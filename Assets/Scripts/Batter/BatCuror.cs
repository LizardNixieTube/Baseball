using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Batter
{
    public class BatCuror : BaseCursor
    {
        private enum CursorState { FOCUS, MEAT, BUNT };
        
        public BatterInputReader BatterInput;

        public GameObject MeatCursor;
        public GameObject BuntArrow;

        public RectTransform PivotRectT;

        private CursorState m_CurrentState;
        private float m_Distance;

        public new void Awake()
        {
            base.Awake();

            m_Distance = m_Cursor.localPosition.x - PivotRectT.localPosition.x; 
        }

        public void OnEnable()
        {
            BatterInput.SwingActions += OnSwing;
            BatterInput.BuntActions  += OnBunt;
            BatterInput.MoveActions  += MoveCursor;
        }

        public void OnDisable()
        {
            BatterInput.SwingActions -= OnSwing;
            BatterInput.BuntActions -= OnBunt;
            BatterInput.MoveActions -= MoveCursor;

        }

        public new void Update()
        {
            base.Update();

            PivotRectT.localPosition = new Vector3(m_Cursor.localPosition.x - m_Distance, PivotRectT.localPosition.y);
            //arctan(y/x) = angle in degree
            float dx = m_Cursor.localPosition.x - PivotRectT.localPosition.x;
            float dy = m_Cursor.localPosition.y - PivotRectT.localPosition.y;
            float angle = Mathf.Rad2Deg * Mathf.Atan(dy / dx);
            m_Cursor.localRotation = new Quaternion
            {
                eulerAngles = new Vector3(0, 0, angle)
            };    
        }

        private void OnSwing()
        {

        }

        private void OnBunt(bool isPressed)
        {

        }
    }
}