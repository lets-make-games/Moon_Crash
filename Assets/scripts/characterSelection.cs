using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class characterSelection : MonoBehaviour
{
    private GameObject engineer;
    private void Start()
    {
        engineer = GameObject.FindGameObjectWithTag("Engineer");
    }
    public void soldierSelection()
    {
        PlayerPrefs.SetInt("character", 0);
        SceneManager.LoadScene("MangoScene", LoadSceneMode.Single);
    }
    public void engineerSelection()
    {
        PlayerPrefs.SetInt("character", 1);
        SceneManager.LoadScene("MangoScene", LoadSceneMode.Single);
    }
    public void SecuritySelection()
    {
        PlayerPrefs.SetInt("character", 2);
        SceneManager.LoadScene("MangoScene", LoadSceneMode.Single);
    }
}
