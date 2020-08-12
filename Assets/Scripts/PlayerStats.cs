using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;
    
    public GameObject player;

    public Text healthText;
    public Slider healthSlider;

    public float health;
    public float maxHealth;

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
