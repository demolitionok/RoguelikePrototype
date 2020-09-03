using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private Controller controller;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        controller = gameObject.GetComponent<Controller>();
    }

    void Update()
    {

        animator.SetFloat("Horizontal", controller.movement.x);
        animator.SetFloat("Vertical", controller.movement.y);
        animator.SetFloat("Speed", controller.movement.sqrMagnitude);

    }
}
