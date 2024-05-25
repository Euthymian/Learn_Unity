using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textCoin;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateUI());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator UpdateUI()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            textCoin.text = GameManager.Instance.GetCoin().ToString();
        }
    }
}
