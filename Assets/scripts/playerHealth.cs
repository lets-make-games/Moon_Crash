using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerHealth : MonoBehaviour
{
    public int Health;
    public int HearthsCount = 3;

    /*public Image[] hearts;
    public Sprite FullHearts;
    public Sprite EmptyHearts;*/
    public Image fullHealth;
    public Image halfHealth;


    public GameObject movepoint;

    private Vector3 knockBack;
    private void Start()
    {
        Health = HearthsCount;


    }
    private void Update()
    {
        if (Health > HearthsCount)   //health limit  put it out after gaining is determ
        {
            Health = HearthsCount;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            Health--;
            HealthLoss();
            knockBack = collision.transform.position - transform.position;
            movepoint.transform.position = transform.position - knockBack;
        }
    }


    void HealthLoss()
    {
        if (Health == 0)
        {
            SceneManager.LoadScene(0);
        }
        else if (Health == 2)
        {
            fullHealth.enabled = false;
        }
        else if (Health == 1)
        {
            halfHealth.enabled = false;
        }
        /*for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Health)
            {
                hearts[i].sprite = FullHearts;
            }
            else { hearts[i].sprite = EmptyHearts; }


            if (i < HearthsCount)
            {
                hearts[i].enabled = true;
            }
            else { hearts[i].enabled = false; }
        }*/

    }
}