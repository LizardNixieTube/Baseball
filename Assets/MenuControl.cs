using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public MenuInputReader InputReader;

    private void OnEnable()
    {
        InputReader.StartActions += StartGame;
    }

    private void StartGame()
    {
        InputReader.StartActions -= StartGame; //remove the function from the action incase of double tap to avoid calling multiple time
        SceneManager.LoadScene("DerbyScene",LoadSceneMode.Single);
    }
}
