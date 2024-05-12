using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    private Vector3 targetPos;
    private float speed = 20;
    private KeyCode previousKey;

    void Start()
    {
        transform.position = pointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position == pointA.position)
        //{
        //    targetPos = pointB.position;
        //}
        //else if (transform.position == pointB.position)
        //{ 
        //    targetPos = pointC.position;
        //}
        //else if (transform.position == pointC.position)
        //{
        //    targetPos = pointD.position;
        //}
        //else if (this.transform.position == pointD.position)
        //{
        //    targetPos = pointA.position;
        //}
        //transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        //transform.LookAt(targetPos);

        if (Input.GetKeyUp(KeyCode.W))
        {
            previousKey = KeyCode.W;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            previousKey = KeyCode.S;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            previousKey = KeyCode.D;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            previousKey= KeyCode.A;
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (Math.Round(transform.localEulerAngles.y,0) != 0)
            {
                if (previousKey == KeyCode.D)
                {
                    transform.Rotate(0, -5, 0);
                }
                else transform.Rotate(0, 5, 0);
            }
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (Math.Round(transform.localEulerAngles.y,0) != 180)
            {
                if (previousKey == KeyCode.A)
                {
                    transform.Rotate(0, -5, 0);
                }
                else transform.Rotate(0, 5, 0);
            }
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (Math.Round(transform.localEulerAngles.y, 0) != 90)
            {
                if (previousKey == KeyCode.S)
                {
                    transform.Rotate(0, -5, 0);
                }
                else transform.Rotate(0, 5, 0);
            }
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (Math.Round(transform.localEulerAngles.y, 0) != 270)
            {
                if (previousKey == KeyCode.W)
                {
                    transform.Rotate(0, -5, 0);
                }
                else transform.Rotate(0, 5, 0);
            }
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
