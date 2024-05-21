using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePrefabsManager : MonoBehaviour
{
    public GameObject myPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(myPrefabs, new Vector3(i * 5, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
