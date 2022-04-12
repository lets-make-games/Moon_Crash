using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject AlienPrefab;

    [SerializeField]
    private float AlienInterval = 15f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(spawnEnemy(AlienInterval, AlienPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject Enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(Enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0),Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, Enemy));
    }

}
