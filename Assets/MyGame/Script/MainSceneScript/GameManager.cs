using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] int health, fuel, laps, coins;
    int capacity;

    public bool ToCheckPos { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        coins = 0;
        laps = 0;
        capacity = 100;
        fuel = 80;
        health = 30;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseLaps()
    {
        laps++;
    }

    public void SetFuel(int addFuel)
    {
        if (fuel < capacity) fuel += addFuel;
    }
    public void DecreaseHealth(int loseHealth)
    {
        health -= loseHealth;
    }
    public int GetHealth()
    {
        return health;
    }
    public void SetCoin(int n)
    {
        coins += n;
    }
    public int GetCoin()
    {
        return coins;
    }
}
