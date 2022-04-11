using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;

    public float invulnPeriod = 0;

    float invulnTimmer = 0;
    int CorrectLayer;


    SpriteRenderer spriteRend;


    void Start()
    {
        CorrectLayer = gameObject.layer;

        // NOTE! This only get the renderer on the parent object.
        // In the other words. In does not work for children 

        spriteRend = GetComponent<SpriteRenderer>();

        if (spriteRend == null)
        {
            spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

            if (spriteRend == null)
            {
                Debug.LogError("Object '" + gameObject.name + "'has no sprite renderer.");
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Debug.Log("Trigger");


            health--;
            invulnTimmer = invulnPeriod;

            gameObject.layer = 7;//Number layer

        }
    }

    void Update()
    {
        if (invulnTimmer > 0)
        {
            invulnTimmer -= Time.deltaTime;

            if (invulnTimmer <= 0)
            {
                gameObject.layer = CorrectLayer;
                if (spriteRend != null)
                {
                    spriteRend.enabled = true;
                }
            }
            else
            {
                if (spriteRend != null)
                {
                    spriteRend.enabled = !spriteRend.enabled;
                }
            }
        }
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
