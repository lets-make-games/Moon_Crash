using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerHealth : MonoBehaviour
{
    public int Health;

    public Image fullHealth;
    public Image halfHealth;

    public GameObject movepoint;

    private Vector3 knockBack;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy") || collision.CompareTag("Electricity"))
        {
            Health--;
            knockBack = collision.transform.position - transform.position;
            movepoint.transform.position = transform.position - knockBack;
            HealthLoss();
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
        float newx = Mathf.Round(movepoint.transform.position.x);
        float newy = Mathf.Round(movepoint.transform.position.y);
        movepoint.transform.position = new Vector2(newx, newy);
        GetComponent<AudioSource>().Play();
    }
}