using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float Speed = 0f;
    public Transform[] target;
    public float Stopping_Distance;

    public int health = 2;

    void Update()
    {
        for (int i = 0; i < target.Length; i++)
        {
            if (Vector2.Distance(transform.position, target[i].position) < Stopping_Distance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target[i].position, Speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            health--;
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
