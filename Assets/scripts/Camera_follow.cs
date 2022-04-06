using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform player;
    Vector3 offset = new Vector3(0, 0, -1);

    private void FixedUpdate()
    {
        transform.position = player.position + offset;
    }

}
