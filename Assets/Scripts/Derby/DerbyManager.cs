using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DerbyManager : MonoBehaviour
{
    public Text RemainCountText;

    private int m_Count = 10;


    public void DecrementCount()
    {
        if(--m_Count == 0)
        {
            //GameOver
            //Display Result
            Debug.Log("GameOver");
        }
        RemainCountText.text = "" + m_Count;
    }
}
