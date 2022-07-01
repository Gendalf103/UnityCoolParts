using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin : MonoBehaviour
{
    void Update()
    {
        //transform.position = new Vector3(0f, Mathf.Sin(Time.time), 0f);
        float sin = Mathf.Sin(Time.time * 10) * 0.5f + 1f;
        transform.localScale = new Vector3(sin, sin, sin);
        
    }
}
