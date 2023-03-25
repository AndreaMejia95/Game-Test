using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [Header ("Move")]
    public Animator animator;
    private float x,y;
    public float runSpeed;
    public float rotationSpeed;

    [Header ("Jump")]
    public Rigidbody rb;
    public float jumpHeigh;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;
    public bool isGround;

    void Update()
    {
        MovePlayer();
        JumpPlayer();
    }

    private void MovePlayer()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0); //rotate
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed); //Run

        animator.SetFloat("VelX", x); //Motion Animation when running/swinging/jumping
        animator.SetFloat("VelY", y); //Motion Animation when running/swinging/jumping

        if(Input.GetKey("q"))
        {
            animator.SetBool("OtherKey", false);
        }

        if(x>0 || x<0 || y>0 || y<0)
        {
            animator.SetBool("OtherKey", true);
        }
    }

    private void JumpPlayer ()
    {   
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(Input.GetKey("space") && isGround)
        {   
            rb.AddForce(Vector3.up * jumpHeigh, ForceMode.Impulse);
            animator.Play("Jump");
        }
    }
}