using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject Door;
    bool open = false;

    private Animator Animator;

    private void Start()
    {
        Animator = Door.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Engineer")
        {
            open = true;
            Animator.SetBool("isOpen", true);  //open animation
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Engineer")
        {
            open = false;
            Animator.SetBool("isOpen", false);  //close animation
        }
    }
}
