using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public int yRange;
    public int xRange;

    public int pickToSpawn;

    public GameObject[] pickups;
    private PlayerHealth playerHP;

    private void Start()
    {
        playerHP = GameObject.Find("player").GetComponent<PlayerHealth>();
    }

    public void SpawnObstacle()
    {
        if (playerHP.health == 3)
        {
            pickToSpawn = 1;
        }
        else
        {
            pickToSpawn= 0;
        }
        float xpos = Random.Range(transform.position.x + xRange, transform.position.x - xRange);
        float ypos = Random.Range(transform.position.y + yRange, transform.position.y - yRange);
        Instantiate(pickups[pickToSpawn], new Vector3(xpos, ypos, 0), Quaternion.identity);
    }

}
