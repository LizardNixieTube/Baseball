using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterAnimation : MonoBehaviour
{
    public RectTransform PivotRectT;
    public Transform BatGripT; //TODO - maybe I can just use real x pos of pivot
    
    private float m_PrevPivotX; //previous pivot position
    private float m_Distance;
    
    public void Awake()
    {
        m_Distance = BatGripT.position.x - gameObject.transform.position.x;
        m_PrevPivotX = Util.CameraTranform.ScreenToWorldPointCamera(Camera.main, PivotRectT).x;
    }

    public void Update()
    {
        float realPivotX = Util.CameraTranform.ScreenToWorldPointCamera(Camera.main, PivotRectT).x;
        if (realPivotX != m_PrevPivotX)
        {
            transform.position += new Vector3(realPivotX - m_PrevPivotX, 0, 0);
            m_PrevPivotX = realPivotX;
        }
    }
}
