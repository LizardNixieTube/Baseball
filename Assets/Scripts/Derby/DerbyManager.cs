using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DerbyManager : MonoBehaviour
{
    public Text RemainCountText;
    public VoidEvent GameOverEvent;
    public MenuInputReader InputReader;

    private int m_Count = 10;

    public void DecrementCount()
    {
        --m_Count;
        RemainCountText.text = "" + m_Count;
        if (m_Count == 0)
        {
            //GameOver
            //Display Result
            GameOverEvent.Raise();
            InputReader.StartActions += Restart;
        }
    }

    private void Restart()
    {
        InputReader.StartActions -= Restart;
        SceneManager.LoadScene("DerbyScene",LoadSceneMode.Single);
    }
}
