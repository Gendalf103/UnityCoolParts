using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class MoveTowards : MonoBehaviour
{
    public float rotationSpeed;
    public float targetZ;

    private float zAngle;

    void Update()
    {
        zAngle = Mathf.MoveTowards(zAngle, targetZ, Time.deltaTime * rotationSpeed);
        transform.eulerAngles = new Vector3(0, 0, zAngle);
    }
}
