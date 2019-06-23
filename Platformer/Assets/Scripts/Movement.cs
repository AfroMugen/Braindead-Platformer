using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Movement : MonoBehaviour
{
    public float moveForce = 5f; public float jumpspeed = 5f;

    public GameObject Ball;
    Rigidbody Body;
    public float bulletspeed = 30f;

   void Start()
   {
     Body = GetComponent<Rigidbody>();
   }

    void FixedUpdate()
    {
        Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, 0) * moveForce;

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            moveVec.y += jumpspeed;
        }

        if (CrossPlatformInputManager.GetButtonDown("Fire"))
        {
            GameObject ball = Instantiate(Ball, transform.position, transform.rotation) as GameObject;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.velocity = transform.TransformDirection(Vector3.forward * bulletspeed);
        }

        Body.AddForce(moveVec);
    }
}