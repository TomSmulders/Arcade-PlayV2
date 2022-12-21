using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject enemy;
    public float minWait;
    public float maxWait;
    private bool isSpawning;


    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        isSpawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSpawning)
        {
            float timer = Random.Range(minWait, maxWait);
            Invoke("SpawnObject", timer);
            isSpawning = true;
        }

    }

    void SpawnObject()
    {
        // Code to spanw your Prefab here
        isSpawning = false;
        GameObject newObject = Instantiate(enemy);
    }

}
