using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    //Variables para desplazarse
    public Animator animator;
    private float x,y;
    public float runSpeed;
    public float rotationSpeed;

    //Variables para salto
    public Rigidbody rb;
    public float jumpHeigh;
    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;
    public bool isGround;
    

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        JumpPlayer();
    }

    private void MovePlayer()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0); //Girar
        transform.Translate(0, 0, y * Time.deltaTime * runSpeed); //Correr

        animator.SetFloat("VelX", x); //Animación del Movimiento al correr/Girar/Saltar
        animator.SetFloat("VelY", y); //Animación del Movimiento al correr/Girar/Saltar

        

        /*if(Input.GetKey("e"))
        {
            animator.Play("Collect");
            animator.SetBool("OtherKey", false);

        }

        if(Input.GetKey("r"))
        {
            animator.Play("Put");
            animator.SetBool("OtherKey", false);

        }*/

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
