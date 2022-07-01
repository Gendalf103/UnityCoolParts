using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Douglas : MonoBehaviour
{
    public Animator anim;
    public Rigidbody[] allRigidbody;
    private void Awake()
    {
        for(int i = 0; i < allRigidbody.Length; i++)
        {
            allRigidbody[i].isKinematic = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysical();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
            MakePhysical();
    }

    public void MakePhysical()
    {
        anim.enabled = false;
        for (int i = 0; i < allRigidbody.Length; i++)
        {
            allRigidbody[i].isKinematic = false;
        }
    }
}
