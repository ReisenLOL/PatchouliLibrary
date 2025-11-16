using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpPower; 
    [SerializeField] private Rigidbody2D rb;
    private Vector2 direction;
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
        rb.linearVelocity = direction * speed;
    }

    private void Movement()
    {
        isOnGround = Physics2D.OverlapCircle(groundCheckPoint.position, 0.05f, groundLayer);
        direction.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            direction.y = jumpPower;
        }
    }
}
