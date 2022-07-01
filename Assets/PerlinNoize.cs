using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoize : MonoBehaviour
{
    void Update()
    {
        float y = Mathf.PerlinNoise(transform.position.x + Time.time, transform.position.z + Time.time);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);

        if (transform.position.y <= 0.5f)
        {
            GetComponent<Renderer>().material.color = Color.white;
        } else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
