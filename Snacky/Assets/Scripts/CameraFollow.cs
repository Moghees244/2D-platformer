using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Transform legs;
    public LayerMask startingGroundLayer;
    float x;
    float y;

    private void Start() { }

    void Update()
    {
        if (this.transform.position != player.position && onStartingGround())
        {
            x = Mathf.Lerp(transform.position.x, player.position.x + 1.5f, 2f * Time.deltaTime);
            y = Mathf.Lerp(transform.position.y, player.position.y + 3f, 2f * Time.deltaTime);
            transform.position = new Vector3(x, y, transform.position.z);
        }

        if (this.transform.position != player.position && !onStartingGround())
        {
            x = Mathf.Lerp(transform.position.x, player.position.x + 1.5f, 2f * Time.deltaTime);
            y = Mathf.Lerp(transform.position.y, player.position.y + 1f, 2f * Time.deltaTime);
            transform.position = new Vector3(x, y, transform.position.z);
        }
    }

    bool onStartingGround()
    {
        return Physics2D.OverlapCircle(legs.position, 0.2f, startingGroundLayer);
    }
}
