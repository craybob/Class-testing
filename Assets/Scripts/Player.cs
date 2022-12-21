using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public float speed;
    public float sprintSpeed;
    [HideInInspector] public Vector3 moveDir;

    public float jumpForce;
    [HideInInspector] public bool ground;

    [HideInInspector] public Animator anim;
    [HideInInspector] public CharacterController controller;

    public virtual void move()
    {
        ground = controller.isGrounded;

        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        controller.Move(moveDir * speed * Time.deltaTime);

        if (moveDir.normalized != Vector3.zero)
        {
            anim.SetBool("move", true);
            transform.forward = moveDir;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
                controller.Move(moveDir * sprintSpeed * Time.deltaTime);
            }
        }
        else
        {
            anim.SetBool("move", false);
        }
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), jumpForce, Input.GetAxisRaw("Vertical"));
            controller.Move(moveDir * jumpForce * Time.deltaTime);
            if (!controller.isGrounded)
            {
                anim.SetBool("isGrounded", false);
                anim.Play("Jump");
            }

        }

        else if (controller.isGrounded)
        {
            anim.SetBool("isGrounded", true);
        }
    }


}
