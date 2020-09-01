using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickupObject { COIN, GEM };
public class CurrencyPickup : MonoBehaviour
{
    public PickupObject currentObject;
    public int pickupQuantity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player") 
        {
            PlayerStats.playerStats.PlayerPickupLoot(currentObject, pickupQuantity);
            Destroy(gameObject);
        }
    }
}
