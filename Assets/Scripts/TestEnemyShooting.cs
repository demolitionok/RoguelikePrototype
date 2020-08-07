﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyShooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform player;
    public float minDamage;
    public float maxDamage;
    public float projectileForce;
    public float cooldown;
    void Start()
    {
        StartCoroutine(ShootPlayer());
    }

    IEnumerator ShootPlayer() 
    {
        yield return new WaitForSeconds(cooldown);
        if (player != null) 
        {
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 targetPos = player.position;
            Vector2 direction = (targetPos - (Vector2)transform.position).normalized;
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<TestEnemyProjectile>().damage = Random.Range(minDamage, maxDamage);
            StartCoroutine(ShootPlayer());
        }
    }
}