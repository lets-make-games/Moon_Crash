using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float Speed = 0f;
    private Transform target;
    public GameObject tar;
    public float Stopping_Distance;


    void Start()
    {
        target = tar.GetComponent<Transform>();
        
    }
    void Update()
    {
        if (Vector2.Distance(transform.position,target.position) < Stopping_Distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
        }
    }
}
