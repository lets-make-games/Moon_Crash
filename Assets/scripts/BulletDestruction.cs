using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestruction : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Wall" || target.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
