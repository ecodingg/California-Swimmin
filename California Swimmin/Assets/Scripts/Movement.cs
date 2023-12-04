using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the player's movement speed.

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        //Rigidbody Setup
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;

        //Sprite Renderer Setup
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        // Input handling for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Flip
        if ((horizontalInput > 0 && spriteRenderer.flipX) || (horizontalInput < 0 && !spriteRenderer.flipX))
        {
            // Flip the player using the SpriteRenderer flipX property
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        // Calculate movement vector
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        // Normalize the vector to ensure consistent movement speed in all directions
        movement.Normalize();

        // Move the player using Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}