using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerHealth : MonoBehaviour
{
    public int Health;
    public int HearthsCount = 3;

    public Image fullHealth;
    public Image halfHealth;

    public GameObject movepoint;

    private Vector3 knockBack;
    private void Start()
    {
        Health = HearthsCount;
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
    }
}