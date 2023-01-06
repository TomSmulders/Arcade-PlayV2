using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalsSpawner : MonoBehaviour
{
    public int yRange;
    public int xRange;

    public GameObject[] Obstacles;


    public void SpawnObstacle()
    {
        float xpos = Random.Range(transform.position.x + xRange, transform.position.x - xRange);
        float ypos = Random.Range(transform.position.y + yRange, transform.position.y - yRange);
        Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], new Vector3(xpos, ypos, 0), Quaternion.identity);
    }
}
