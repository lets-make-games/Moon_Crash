using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float Speed = 0f;
    public Transform[] target;
    public float Stopping_Distance;

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
}
