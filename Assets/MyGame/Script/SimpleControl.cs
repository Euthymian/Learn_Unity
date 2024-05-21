using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleControl : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed, rotateSpeed;
    [SerializeField] GameObject getFuelEffect, explosionEffect;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fuel")
        {
            Destroy(other.gameObject);
            GameManager.Instance.SetFuel(10);
            Instantiate(getFuelEffect, other.transform.position, Quaternion.identity);
        }
        else if (other.name == "CheckIntegrityLap")
        {
            GameManager.Instance.ToCheckPos = true;
        }
        else if (other.name == "Entrance")
        {
            if (GameManager.Instance.ToCheckPos == true)
            {
                GameManager.Instance.ToCheckPos = false;
                GameManager.Instance.IncreaseLaps();
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rock")
        {
            Destroy(collision.gameObject);
            GameManager.Instance.DecreaseHealth(10);
        }
        if (GameManager.Instance.GetHealth() == 0)
        {
            Instantiate(explosionEffect, this.transform.position, Quaternion.identity);
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
