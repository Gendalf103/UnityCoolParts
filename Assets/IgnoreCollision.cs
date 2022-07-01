using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    public Collider colliderA;
    public Collider colliderB;
    void Start()
    {
        Physics.IgnoreCollision(colliderB, colliderA);
    }

}
