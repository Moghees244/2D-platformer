using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EnemyDamage : MonoBehaviour
{
    BoxCollider2D collider;
    public LayerMask mask;

    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Physics2D.OverlapBox(transform.position, Vector2.zero, 0f, mask))
            ScoreKeeper.health -= 5;
    }
}
