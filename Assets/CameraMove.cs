using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity = 0.4f;

    [SerializeField]
    private float moveSpeed = 2f;

    private Vector3 mousePreveousePos;
    private float rotationX;
    private float rotationY;

    void Update()
    {
        Move();
        Rotation();
    }

    void Move()
    {
        float shiftMult = 1f;
        if(Input.GetKey(KeyCode.LeftShift))
        {
            shiftMult = 3f;
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float z = 0;
        if(Input.GetKey(KeyCode.E))
        {
            z = 1;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            z = -1;
        }

        Vector3 offset = new Vector3(x, z, y) * moveSpeed * shiftMult * Time.deltaTime;
        //transform.position += offset;
        transform.Translate(offset);
    }

    void Rotation()
    {
        Vector3 mouseDelta;

        if (Input.GetMouseButtonDown(1))
        {
            mousePreveousePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            mouseDelta = Input.mousePosition - mousePreveousePos;
            mousePreveousePos = Input.mousePosition;
            rotationX -= mouseDelta.y * mouseSensitivity;
            rotationY += mouseDelta.x * mouseSensitivity;

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
    }
}
