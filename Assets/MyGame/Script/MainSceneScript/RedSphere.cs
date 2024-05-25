using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSphere : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //rb.AddForce(new Vector3(10,0,10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Start colliding");
        Debug.Log(collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay colliding");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Finish colliding");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Start trigger");
        Debug.Log(other.gameObject.name);
        // Debug.Log(other.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay trigger");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Finish trigger");
    }
}
