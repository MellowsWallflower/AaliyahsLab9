using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1Controller : MonoBehaviour
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
        MoveNPC1();
    }

    void MoveNPC1()
    {
        float moveX = 0f;
        float moveY = 0f;

        // Check for input using different keys for NPC1
        if (Input.GetKey(KeyCode.H))
        {
            moveY = 1f; // Move up
        }
        else if (Input.GetKey(KeyCode.N))
        {
            moveY = -1f; // Move down
        }

        if (Input.GetKey(KeyCode.B))
        {
            moveX = -1f; // Move left
        }
        else if (Input.GetKey(KeyCode.M))
        {
            moveX = 1f; // Move right
        }

        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement.normalized * moveSpeed;
    }
}
