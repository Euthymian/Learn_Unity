using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance
    {
        get => instance;
    }
    private static GameManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(instance);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    public bool ToCheckPos { get; set; }
    public UnityEvent<int> CoinEvent;
    public UnityEvent<int> LapsEvent;
    [SerializeField] int health, fuel, laps, coins;
    int capacity;

    // Start is called before the first frame update
    void Start()
    {
        if (CoinEvent == null)
        {
            CoinEvent = new UnityEvent<int>();
        }
        if (LapsEvent == null)
        {
            LapsEvent = new UnityEvent<int>();
        }
        coins = DataManager.DataCoin;
        CoinEvent?.Invoke(coins);

        laps = DataManager.DataLaps;
        LapsEvent?.Invoke(laps);

        capacity = 100;
        fuel = 80;
        health = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseLaps()
    {
        laps++;
        GameManager.Instance.LapsEvent?.Invoke(laps);
        DataManager.DataLaps = laps;
    }
    public void SetCoin(int n)
    {
        coins += n;
        GameManager.Instance.CoinEvent?.Invoke(coins);
        DataManager.DataCoin = coins;
    }

    public void SetFuel(int addFuel)
    {
        if (fuel < capacity) fuel += addFuel;
    }

    #region Getter Setter Health
    public void DecreaseHealth(int loseHealth)
    {
        health -= loseHealth;
    }
    public int GetHealth()
    {
        return health;
    }
    #endregion
}
