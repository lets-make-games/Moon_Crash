using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Instruction()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
