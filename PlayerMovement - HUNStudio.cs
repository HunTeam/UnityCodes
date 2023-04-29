using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    public Rigidbody rb;
    Vector3 moveDir = Vector3.zero; //(0,0,0)

    public float walk = 6f;
    public float jump = 8f;
    public float gravity = 20f;
    public float run = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
                moveDir *= run;
            }
            else { 
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDir *= walk;
            }
            if (Input.GetButton("Jump"))
            {
                moveDir.y = jump;
            }
        }
        moveDir.y -=  gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}
