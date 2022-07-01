using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;
    public float rotationSpeed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = Mathf.Infinity;
    }

    void Update()
    {
        float sideForce = Input.GetAxis("Horizontal") * rotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * speed;

        rb.AddRelativeForce(0, 0, forwardForce);
        rb.AddRelativeTorque(0, sideForce, 0);

        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddRelativeTorque(rotationSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            rb.AddRelativeTorque(-rotationSpeed, 0, 0);
        }
    }
}
