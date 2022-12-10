using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    float speed = 10f;
    [System.NonSerialized] public Transform parentTrans;

    private void Start()
    {
        Destroy(gameObject, 3f);

        if (parentTrans.GetComponent<EnemyMovements>().isFacingRight)
            speed *= -1;
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
