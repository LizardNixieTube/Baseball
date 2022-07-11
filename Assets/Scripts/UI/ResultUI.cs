using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultUI : MonoBehaviour
{
    public VoidEvent ResetEvent; //TODO - will display speed/ball type later so have to move this later
    private Text m_DisplayText;
    private float m_DisplayTime = 1.5f;

    // Start is called before the first frame update
    public void Start()
    {
        m_DisplayText = GetComponent<Text>();
        m_DisplayText.enabled = false;
    }

    public void ShowResult(bool isStrike)
    {
        Debug.Log("ShowResult: " + isStrike);

        if (isStrike)
        {
            m_DisplayText.color = Color.red;
            m_DisplayText.text = "STRIKE";
        }
        else
        {
            m_DisplayText.color = Color.cyan;
            m_DisplayText.text = "BALL";
            
        }
        m_DisplayText.enabled = true;
        StartCoroutine("Show");
    }

    //Wait for certain time until hide the text and invoke next event
    private IEnumerator Show()
    {
        yield return new WaitForSeconds(m_DisplayTime);
        m_DisplayText.enabled = false;
        ResetEvent.Raise();
    }

}
