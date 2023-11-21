using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoogiemanController : MonoBehaviour
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
        MoveBoogieman();
    }

    void MoveBoogieman()
    {
        float moveX = 0f;
        float moveY = 0f;

        // Check for input using different keys for Boogieman
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }

        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement.normalized * moveSpeed;
    }
}
