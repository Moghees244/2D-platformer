using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Shooter : MonoBehaviour
{
    public List<Bullet> bullets;
    float bulletSpeed;
    float nextShottime;
    float msDiff = 2;

    private void Start()
    {
        nextShottime = Time.time;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time >= nextShottime)
            {
                Bullet bullet =
                    Instantiate(bullets[0], transform.position, Quaternion.identity) as Bullet;

                nextShottime = Time.time + (msDiff/10f);
            }
        }
    }
}
