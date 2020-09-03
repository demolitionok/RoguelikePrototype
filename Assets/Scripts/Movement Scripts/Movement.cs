using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Controller controller;
    public float moveSpeed = 3f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        controller = gameObject.GetComponent<Controller>();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + controller.movement * moveSpeed * Time.fixedDeltaTime);
    }
}
