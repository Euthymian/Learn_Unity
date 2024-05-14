using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    public float nextTime = 0;
    public GameObject prefabs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextTime)
        {
            Debug.Log(Time.time);  // Total time game run after clicked Start
            nextTime = Time.time + 0.5f;
            Instantiate(prefabs, new Vector3(0, Random.RandomRange(0, 100), 0), Quaternion.identity);
        }
        //print(Input.GetAxis("Horizontal"));
    }
}
