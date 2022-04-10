using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportTo;
    private GameObject movepoint;
    private AudioSource teleportSound;

    private Animator camAnim;
    private void Start()
    {
        teleportSound = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D colli)
    {
        movepoint = GameObject.FindGameObjectWithTag("movePoint");  //define movepoint

        movepoint.transform.position = gameObject.GetComponent<Renderer>().bounds.center;
        colli.transform.position = gameObject.GetComponent<Renderer>().bounds.center;

        colli.GetComponent<movement>().enabled = false;  //disable movement

        StartCoroutine(time());

        IEnumerator time()
        {
            camAnim = colli.GetComponent<Animator>(); //cam shake
            camAnim.SetBool("teleporting", true);

            teleportSound.Play(0);  //sound
            yield return new WaitForSeconds(3);  //timer

            movepoint.transform.position = teleportTo.transform.position;  //move the point
            colli.transform.position = teleportTo.transform.position;  //move the player
            colli.GetComponent<movement>().enabled = true; //enable movement

            camAnim.SetBool("teleporting", false);
        }
    }


}
