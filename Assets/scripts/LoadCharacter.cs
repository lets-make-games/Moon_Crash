using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characters;
    void Start()
    {
        int characterNum = PlayerPrefs.GetInt("character");
        for (int i = 0; i < 3; i++)
        {
            characters[characterNum].SetActive(true);
        }
    }
}
