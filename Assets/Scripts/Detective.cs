using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detective : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }

    void Update()
    {
        MoveDetective();
    }

    void MoveDetective()
    {
        float moveX = 0f;
        float moveY = 0f;

        // Check for input using different keys for the Detective
        if (Input.GetKey(KeyCode.I))
        {
            moveY = 1f; // Move up
        }
        else if (Input.GetKey(KeyCode.K))
        {
            moveY = -1f; // Move down
        }

        if (Input.GetKey(KeyCode.J))
        {
            moveX = -1f; // Move left
        }
        else if (Input.GetKey(KeyCode.L))
        {
            moveX = 1f; // Move right
        }

        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement.normalized * moveSpeed;
    }
}
