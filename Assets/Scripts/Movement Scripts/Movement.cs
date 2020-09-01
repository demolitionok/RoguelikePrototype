using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Controller controller;
    public float moveSpeed = 3f;

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
