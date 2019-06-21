using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float speed = 8.0f;
    public float jumpspeed = 20.5f;
    public float gravity = 20.0f;
    Vector3 moveDirection = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Horizontal") + 3);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpspeed;
            }
        }

        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y += jumpspeed;
            }
        }

            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
    }
}