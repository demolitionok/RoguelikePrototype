using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    protected GameObject player;
    protected virtual void Start()
    {
        var pc = FindObjectOfType<PlayerController>();
        if (pc != null)
            player = pc.gameObject;
        
    }
}
