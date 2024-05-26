using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static int DataCoin 
    {
        get => PlayerPrefs.GetInt(DataContainer.CoinID, 0);
        set => PlayerPrefs.SetInt(DataContainer.CoinID, value);
    }

    public static int DataLaps
    {
        get => PlayerPrefs.GetInt(DataContainer.LapsID, 0);
        set => PlayerPrefs.SetInt(DataContainer.LapsID, value);
    }
}
