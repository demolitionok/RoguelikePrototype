﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthBar;
    public Slider healthBarSlider;

    public GameObject lootDrop;

    void Start()
    {
        health = maxHealth;
        healthBarSlider = healthBar.GetComponent<Slider>();
    }
    public void DealDamage(float damage) 
    {
        healthBar.SetActive(true);
        health -= damage;
        CheckDeath();
        healthBarSlider.value = CalculateHealthPercentage();
    }
    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverheal();
        healthBarSlider.value = CalculateHealthPercentage();
    }
    private void CheckDeath() 
    {
        if (health <= 0)
        {
            Instantiate(lootDrop, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    private void CheckOverheal() 
    {
        if (health > maxHealth) 
        {
            health = maxHealth;
        }
    }

    private float CalculateHealthPercentage() 
    {
        return (health / maxHealth);
    }
}