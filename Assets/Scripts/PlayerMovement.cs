﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerController controller;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        controller = gameObject.GetComponent<PlayerController>();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + controller.movement * controller.moveSpeed * Time.fixedDeltaTime);
    }
}
