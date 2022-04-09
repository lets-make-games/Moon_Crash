using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;

    private Animator animator;

    public LayerMask whatIsSolid;
    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("Speed", 1);
    }
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.right, distance , whatIsSolid);
        if (groundInfo.collider == true)
        {
            movingRight = !movingRight;
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                animator.SetFloat("Horizontal", 1);
            }
            else if (movingRight == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                animator.SetFloat("Horizontal", 1);
            }
        }
    }
}