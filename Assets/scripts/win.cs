using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Engineer")
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
        }
        if (collision.gameObject.tag == "Soldier")
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
        }
        if (collision.gameObject.tag == "Security")
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);
        }
    }
}
