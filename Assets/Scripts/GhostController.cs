using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
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
        MoveGhost();
    }

    void MoveGhost()
    {
        float moveX = 0f;
        float moveY = 0f;

        // Check for input using alternative keys for the Ghost
        if (Input.GetKey(KeyCode.F))
        {
            moveY = 1f; // Move up
        }
        else if (Input.GetKey(KeyCode.C))
        {
            moveY = -1f; // Move down
        }

        if (Input.GetKey(KeyCode.X))
        {
            moveX = -1f; // Move left
        }
        else if (Input.GetKey(KeyCode.V))
        {
            moveX = 1f; // Move right
        }

        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement.normalized * moveSpeed;
    }
}
