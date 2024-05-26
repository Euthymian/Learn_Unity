using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textCoin;
    public TextMeshProUGUI textLaps;
    // Start is called before the first frame update
    void Start()
    {
        textCoin.text = DataManager.DataCoin.ToString();
        textLaps.text = DataManager.DataLaps.ToString();
        GameManager.Instance.CoinEvent.AddListener(UpdateCoins);
        GameManager.Instance.LapsEvent.AddListener(UpdateLaps);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateLaps(int laps)
    {
        textLaps.text = laps.ToString();
    }
    void UpdateCoins(int coins)
    {
        textCoin.text = coins.ToString();
    }
}
