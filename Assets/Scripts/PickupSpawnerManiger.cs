using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickupSpawnerManiger : MonoBehaviour
{
    public PickupSpawner[] spawners;

    public int startTime = 2;
    public int endTime = 15;

    

    // Start is called before the first frame update
    void Start()
    {
        float newTime = Random.Range(startTime, endTime);
        StartCoroutine(spawninterval(newTime));
    }

    void Update()
    {

    }

    IEnumerator spawninterval(float time)
    {
        yield return new WaitForSeconds(time);
        spawners[0].SpawnObstacle();
        float newTime = Random.Range(startTime, endTime);
        StartCoroutine(spawninterval(newTime));
        yield return null;
    }
}
