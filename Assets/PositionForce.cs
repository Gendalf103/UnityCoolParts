using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionForce : MonoBehaviour
{
    public Rigidbody targetRigidbody;
    public float forceValue = 200f;
    public ParticleSystem ps;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            targetRigidbody.AddForceAtPosition(
                transform.up * forceValue, 
                transform.position
            );
            ps.Play();
        }
    }
}
