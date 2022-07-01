using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletMask;
    public bool isActive = true;

    private void OnCollisionEnter(Collision collision)
    {
        //if (!isActive) return;

        //isActive = false;

        Debug.Log(collision.gameObject.name);

        GetComponent<Rigidbody>().useGravity = true;

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.OnHit();
            if (collision.collider.GetComponent<EnemyHead>())
            {
                Debug.Log("Headshot");
            }
        }

        if (collision.gameObject.tag == "MyGround")
        {
            Vector3 position = collision.contacts[0].point;
            Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);
            Instantiate(bulletMask, position, rotation);
        }

        Douglas douglas = collision.gameObject.GetComponentInParent<Douglas>();
        if(douglas)
        {
            douglas.MakePhysical();
        }
    }
}
