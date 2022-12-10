using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyMovements : MonoBehaviour
{
    float horizontalMovementDirection;

    [Range(3, 10)]
    public float speed;
    public bool isFacingRight = true;
    float centre;
    public float platformLength;

    private void Start()
    {
        centre = transform.position.x;
    }

    void Update()
    {
        if (transform.position.x >= centre + platformLength || transform.position.x <= centre - platformLength)
        {
            flip();
            speed *= -1;
        }

        transform.Translate(new Vector3(speed * Time.deltaTime, 0f, 0f));
        horizontalMovementDirection = transform.position.x;
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
