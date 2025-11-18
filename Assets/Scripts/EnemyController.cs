using System;
using UnityEngine;

public class EnemyController : Unit
{
    public PlayerController player;
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(player.transform.position.x - transform.position.x, rb.linearVelocity.y).normalized * speed;
    }
}
