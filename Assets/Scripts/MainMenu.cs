using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(string difficulty)
    {
        SceneManager.LoadScene("SampleScene");
        GameValues.difficulty = difficulty;
    }

    public void GobacktoMainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Player Has Quit the Game"); //optional
    }
}
