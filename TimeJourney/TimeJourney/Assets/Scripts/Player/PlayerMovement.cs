﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] CharacterController2D controller;
    [SerializeField] Animator animator;

    public float runSpeed = 7f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
	
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }


    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    //public void OnCrouching(bool isCrouching)
    //{
    //    //trebuie pus in update
    //    if (Input.GetButtonDown("Crouch"))
    //    {
    //        crouch = true;
    //    }else if(Input.GetButtonUp("Crouch"))
    //    {
    //        crouch = false;
    //    }
    ////    animator.SetBool("IsCrouching", isCrouching);
    ////}
}