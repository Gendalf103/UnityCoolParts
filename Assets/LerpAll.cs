using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LerpAll : MonoBehaviour
{
    public Transform t1;
    public Transform t2;

    public Material m1;
    public Material m2;

    public Material m3;

    //[Range(0, 1)]
    public float value;

    void Update()
    {
        //value = Input.GetAxis("Horizontal") * 0.5f + 0.5f; //-1 1 --- 0 1
        transform.position = Vector3.LerpUnclamped(t1.position, t2.position, value);
        transform.localScale = Vector3.LerpUnclamped(t1.localScale, t2.localScale, value);
        transform.rotation = Quaternion.LerpUnclamped(t1.rotation, t2.rotation, value);
        m3.color = Color.LerpUnclamped(m1.color, m2.color, value);
    }
}
