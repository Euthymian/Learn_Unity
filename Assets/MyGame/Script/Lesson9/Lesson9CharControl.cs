using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9CharControl : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IdleToWalk", true);
            if (Input.GetKey(KeyCode.A)) animator.SetBool("WalkTurnLeft", true);
            else if (Input.GetKey(KeyCode.D)) animator.SetBool("WalkTurnRight", true);
            else if (Input.GetKey(KeyCode.R)) animator.SetBool("Run", true);
            else
            {
                animator.SetBool("Run", false);
                animator.SetBool("WalkTurnLeft", false);
                animator.SetBool("WalkTurnRight", false);
            }
        }
        else animator.SetBool("IdleToWalk", false); 
    }
}
