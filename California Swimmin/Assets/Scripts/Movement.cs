using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the player's movement speed.

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input handling for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        // Normalize the vector to ensure consistent movement speed in all directions
        movement.Normalize();

        // Move the player using Rigidbody
        rb.velocity = movement * moveSpeed;
    }
}