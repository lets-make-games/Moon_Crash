using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5f;
    public Transform movePoint;

    public LayerMask WhatIsSolid;

    private Animator animator;

    private void Start()
    {
        movePoint.parent = null;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime); //move to point

        Vector3 HorozontalVec = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f); //assigning values
        Vector3 VerticalVec = new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
        float HorInput = Input.GetAxisRaw("Horizontal");
        float VerInput = Input.GetAxisRaw("Vertical");


        if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            animator.SetFloat("Speed", Mathf.Abs(HorInput) + Mathf.Abs(VerInput));  //set hor and ver parameters


            if (HorInput == 1f)  //moving right
            {

                if (!Physics2D.OverlapCircle(movePoint.position + HorozontalVec, 0.2f, WhatIsSolid))
                {
                    movePoint.position += HorozontalVec;
                    animator.SetFloat("Horizontal", 1f);
                }
            }
            else if (HorInput == -1f)  //moving left
            {

                if (!Physics2D.OverlapCircle(movePoint.position + HorozontalVec, 0.2f, WhatIsSolid))
                {
                    movePoint.position += HorozontalVec;
                    animator.SetFloat("Horizontal", -1f);
                }
            }


            else if (VerInput == 1f)  //moving up
            {
                if (!Physics2D.OverlapCircle(movePoint.position + VerticalVec, 0.2f, WhatIsSolid))
                {
                    movePoint.position += VerticalVec;
                    animator.SetFloat("Vertical", 1f);
                }
            }
            else if (VerInput == -1f)  //moving down
            {
                if (!Physics2D.OverlapCircle(movePoint.position + VerticalVec, 0.2f, WhatIsSolid))
                {
                    movePoint.position += VerticalVec;
                    animator.SetFloat("Vertical", -1f);
                }
            }
            if (VerInput == 0f)  //idle
            {
                animator.SetFloat("Vertical", 0f);
            }
            else if (HorInput == 0f)  //idle
            {
                animator.SetFloat("Horizontal", 0f);
            }
        }
    }
}