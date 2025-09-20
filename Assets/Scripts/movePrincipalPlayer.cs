using System;
using UnityEngine;

public class movePrincipalPlayer: MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float moveSpeed = 5f;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        //walking
        float horizontalInput = Input.GetAxis("Horizontal");
        body.linearVelocity = new Vector2(horizontalInput * moveSpeed, body.linearVelocity.y);
        //jumping
        float verticalInput = Input.GetAxis("Vertical");
        if (verticalInput > 0.1f && Math.Abs(body.linearVelocity.y) < 0.001f)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, verticalInput * moveSpeed);
        }
    }
}
