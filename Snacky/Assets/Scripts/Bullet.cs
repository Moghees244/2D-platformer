using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10f;

    private void Start()
    {
        Destroy(gameObject, 3f);

        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isFacingRight)
            speed*=-1;
    }

    private void Update() {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

}
