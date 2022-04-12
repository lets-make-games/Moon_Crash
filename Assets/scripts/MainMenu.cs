using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MangoScene");
    }

    public void Instruction()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("MarckScene");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
