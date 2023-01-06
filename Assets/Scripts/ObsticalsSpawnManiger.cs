using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalsSpawnManiger : MonoBehaviour
{
    public ObsticalsSpawner[] spawners;

    public int startTime = 2;
    public int endTime = 15;

    // Start is called before the first frame update
    void Start()
    {
        float newTime = Random.Range(startTime, endTime);
        StartCoroutine(spawninterval(newTime));
    }

    IEnumerator spawninterval(float time)
    {
        yield return new WaitForSeconds(time);
        spawners[Random.Range(0, spawners.Length)].SpawnObstacle();
        float newTime = Random.Range(startTime, endTime);
        StartCoroutine(spawninterval(newTime));
        yield return null;
    }
}
