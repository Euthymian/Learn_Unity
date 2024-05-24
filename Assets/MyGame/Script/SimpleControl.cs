using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleControl : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed, rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleManualDriving();
    }

    void HandleManualDriving()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * vertical * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        float turn = horizontal * rotateSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
