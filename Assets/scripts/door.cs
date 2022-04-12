using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject Door;

    private Animator Animator;

    private AudioSource doorSound;
    private void Start()
    {
        Animator = Door.GetComponent<Animator>();
        doorSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Engineer")
        {
            Animator.SetBool("isOpen", true);  //open animation
            doorSound.Play(0);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Engineer")
        {
            Animator.SetBool("isOpen", false);  //close animation
            doorSound.Play(0);
        }
    }
}
