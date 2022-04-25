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

    private movement movement;

    private void Start()
    {
        movement = GetComponent<movement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            Health--;
            if (!Physics2D.OverlapCircle(movement.movePoint.position, 1f, movement.WhatIsSolid))
            {
                knockBack = collision.transform.position - transform.position;
                movepoint.transform.position = transform.position - knockBack;
                float newx = Mathf.Round(movepoint.transform.position.x);
                float newy = Mathf.Round(movepoint.transform.position.y);
                movepoint.transform.position = new Vector2(newx, newy);
            }
            HealthLoss();
        }
        if (collision.CompareTag("gas"))
        {
            Health--;
            if (!Physics2D.OverlapCircle(movement.movePoint.position, 1f, movement.WhatIsSolid))
            {
                knockBack = collision.transform.position - transform.position;
                movepoint.transform.position = transform.position - knockBack;
                float newx = Mathf.Round(movepoint.transform.position.x);
                float newy = Mathf.Round(movepoint.transform.position.y);
                movepoint.transform.position = new Vector2(newx, newy);
            }
            HealthLoss();
            collision.GetComponent<AudioSource>().Play();
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

        GetComponent<AudioSource>().Play();
    }
}