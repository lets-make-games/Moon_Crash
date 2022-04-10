using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTo;
    private GameObject movepoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        movepoint = GameObject.FindGameObjectWithTag("movePoint");  //define movepoint

        movepoint.transform.position = gameObject.GetComponent<Renderer>().bounds.center;
        collision.transform.position = gameObject.GetComponent<Renderer>().bounds.center;

        collision.GetComponent<movement>().enabled = false;  //disable movement

        StartCoroutine(time());

        IEnumerator time()
        {
            yield return new WaitForSeconds(2);

            movepoint.transform.position = teleportTo.transform.position;  //move the point
            collision.transform.position = teleportTo.transform.position;  //move the player
            collision.GetComponent<movement>().enabled = true; //enable movement
        }
    }
}
