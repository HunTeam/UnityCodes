using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    public float gravity = 20f;
    public float run = 10f;
    public float walk = 6f;
    public float jump = 7f;
    PhotonView PV;

    void Start()
    {
        PV = GetComponent<PhotonView>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (PV.IsMine)
        {
            if (controller.isGrounded)
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    moveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
                    moveDir *= run;
                }
                else
                {
                    moveDir = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
                    moveDir *= walk;
                }
                if (Input.GetButton("Jump"))
                {
                    moveDir.y = jump;
                }
            }

        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }
}
