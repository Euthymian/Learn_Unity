using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(slider.name + " " + slider.maxValue + " " + slider.minValue);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(slider.value);   
    }

    public void OnValueChangeSlider()
    {
        Debug.Log("Changed to " + slider.value);
    }
}
