using System;
using UnityEngine;

public class PlayerController : Unit
{
    public float jumpPower; 
    private float horizontal;
    public bool isOnGround;
    public Transform groundCheckPoint;
    public LayerMask groundLayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal, rb.linearVelocity.y);
    }

    private void Movement()
    {
        isOnGround = Physics2D.OverlapCircle(groundCheckPoint.position, 0.05f, groundLayer);
        horizontal = Input.GetAxisRaw("Horizontal") * speed;
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        }
    }
}
