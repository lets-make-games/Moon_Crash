using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject Player;
    public GameObject MovePoint;
    void Start()
    {
        int spawnRand = Random.Range(0, spawnPoints.Length);  //spawn
        Player.transform.position = spawnPoints[spawnRand].position;
        MovePoint.transform.position = spawnPoints[spawnRand].position;
    }


}
