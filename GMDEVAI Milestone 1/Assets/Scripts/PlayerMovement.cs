using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float movementSpeed = 5;
    float rotationSpeed = 3;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        // Mouse Look
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);

        // Strafe
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}
