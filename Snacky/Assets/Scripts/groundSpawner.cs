using Unity.Mathematics;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
    public Transform platform;
    public Transform player;
    Vector2 spawnerPosition;
    int yaxis;
    int xaxis;
    int platformCount = 10;

    private void Start()
    {
        spawnerPosition = player.position;
    }

    void Update()
    {
        if (platformCount != 0)
        {
            xaxis = UnityEngine.Random.Range(-5, 5);
            yaxis = UnityEngine.Random.Range(2, 5);

            spawnerPosition.x += xaxis;
            spawnerPosition.y += yaxis;

            Instantiate(platform, spawnerPosition, quaternion.identity);
            platformCount--;
        }
    }
}
