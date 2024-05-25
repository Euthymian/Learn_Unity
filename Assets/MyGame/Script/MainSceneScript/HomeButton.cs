using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(ToHomeUI);
    }

    private void ToHomeUI()
    {
        SceneManager.LoadScene("MainUIScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
