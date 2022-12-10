using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalMovementDirection;

    [SerializeField]
    private Rigidbody2D playerBody;

    [SerializeField]
    private Transform legs;

    [SerializeField]
    private LayerMask groundLayer;

    [SerializeField]
    private LayerMask startingGroundLayer;
    float speed = 8f;
    float shortJumpingPower = 0.5f;
    float longJumpingPower = 20f;
    public bool isFacingRight = false;

    private void Update()
    {
        horizontalMovementDirection = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W) && (isOnGround() || isOnStartingGround()))
            playerBody.velocity = new Vector2(playerBody.velocity.x, longJumpingPower);

        if (Input.GetKeyUp(KeyCode.W) && playerBody.velocity.y > 0f)
            playerBody.velocity = new Vector2(
                playerBody.velocity.x,
                playerBody.velocity.y * shortJumpingPower
            );

        flip();
    }

    private void FixedUpdate()
    {
        playerBody.velocity = new Vector2(
            horizontalMovementDirection * speed,
            playerBody.velocity.y
        );
    }

    bool isOnGround()
    {
        return Physics2D.OverlapCircle(legs.position, 0.2f, groundLayer);
    }

    bool isOnStartingGround()
    {
        return Physics2D.OverlapCircle(legs.position, 0.2f, startingGroundLayer);
    }

    void flip()
    {
        if (
            isFacingRight && horizontalMovementDirection < 0f
            || !isFacingRight && horizontalMovementDirection > 0f
        )
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
