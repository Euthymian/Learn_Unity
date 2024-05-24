using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionManager : MonoBehaviour
{
    [SerializeField] GameObject getFuelEffect, explosionEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Instantiate(explosionEffect, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 1.5f), Quaternion.identity);
            this.GetComponent<SimpleControl>().enabled = false;
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
