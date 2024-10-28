using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRB : MonoBehaviour
{
    Rigidbody rb;
    public float playerSpeed = 2.0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3 (0f, 0f, Input.GetAxis("Vertical"));
        Vector3 moveRelative = transform.TransformDirection(move) * playerSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + moveRelative);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
