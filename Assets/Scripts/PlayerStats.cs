using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;
    
    public GameObject player;

    public Text healthText;
    public Text coinText;
    public Slider healthSlider;

    public float health;
    public float maxHealth;

    public int coins = 0;
    public int gems = 0;

    private void Awake()
    {
        if (playerStats != null)
        {
            Destroy(playerStats);
        }
        else 
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        health = maxHealth;
        SetHealthUi();
    }
    public void DealDamage(float damage)// сделать через сетер
    {
        health -= damage;
        CheckDeath();
        SetHealthUi();
    }
    public void HealCharacter(float heal) // сделать через сетер
    {
        health += heal;
        CheckOverheal();
        SetHealthUi();
    }
    private void SetHealthUi()
    {
        healthSlider.value = CalculateHealthPercentage();
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxHealth).ToString();
    }
    private void SetCoinsUi() 
    {
        coinText.text = "Coins:" + coins;
    }
    public void PlayerPickupLoot(PickupObject currentObject, int pickupQuantity)
    {
        if (currentObject == PickupObject.COIN)
        {
            playerStats.coins += pickupQuantity;

        }
        else if (currentObject == PickupObject.GEM)
        {
            playerStats.gems += pickupQuantity;

        }
        SetCoinsUi();
    }
    private void CheckOverheal()// сделать через сетер
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    private void CheckDeath()// сделать через сетер
    {
        if (health <= 0) 
        {
            Destroy(player);
        }
    }
    float CalculateHealthPercentage() 
    {
        return health / maxHealth;
    }
}
