using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private float _health;
    public float health
    {
        set
        {
            _health = value;
            OnHpChange.Invoke();

            if (_health > maxHealth)
                _health = maxHealth;
            if (health <= 0)
            {
                OnDeath.Invoke();
                Destroy(gameObject);
            }
        }
        get
        {
            return _health;
        }
    }
    public UnityEvent OnHpChange;
    public UnityEvent OnDeath;
    public float maxHealth;

    public Slider healthBarSlider;

    public GameObject lootDrop;

    void Start()
    {
        OnHpChange.AddListener(SetHealthValue);
        health = maxHealth;
        OnDeath.AddListener(SpawnLootDrop);
    }
    public void DealDamage(float damage) 
    {
        health -= damage;
    }
    public void HealCharacter(float heal)
    {
        health += heal;
    }
    private void SpawnLootDrop()
    {
        Instantiate(lootDrop, transform.position, Quaternion.identity);
    }
    public void SetHealthValue() 
    {
        healthBarSlider.value = CalculateHealthPercentage();
    }
    private float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }

}
