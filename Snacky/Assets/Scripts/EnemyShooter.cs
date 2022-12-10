using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyShooter : MonoBehaviour
{
    public List<EnemyBullet> bullets;
    [Range(0,1)]
    public int bulletType;
    float bulletSpeed;
    float nextShottime;
    float msDiff = 4;

    private void Start()
    {
        nextShottime = Time.time;
    }

    private void Update()
    {
            if (Time.time >= nextShottime)
            {
                EnemyBullet bullet =
                    Instantiate(bullets[0], transform.position, Quaternion.identity) as EnemyBullet;
                    bullet.parentTrans=transform.parent;

                nextShottime = Time.time + msDiff/10;
            }
    }
}
