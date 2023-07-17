using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public GameObject[] spawner;
    int randomSpawner;
    public float spawnTimeBase;
    float spawnTimeCurrent;

    void Start()
    {
        spawnTimeCurrent = spawnTimeBase;
    }

    void Update()
    {
        spawnTimeCurrent -= Time.deltaTime;
        if(spawnTimeCurrent <= 0)
        {
            spawnTimeCurrent = spawnTimeBase;
            GameObject ballSpawn;
            randomSpawner = Random.Range(0, spawner.Length);
            ballSpawn = Instantiate(ball, spawner[randomSpawner].transform.position, spawner[randomSpawner].transform.rotation);
        }

        if(InGameManager.instance.score <= 1000)
        {
            spawnTimeBase = 5;
        }
        else if(InGameManager.instance.score >= 1001 && InGameManager.instance.score <= 5000)
        {
            spawnTimeBase = 4;
        }
        else if (InGameManager.instance.score >= 5001 && InGameManager.instance.score <= 12000)
        {
            spawnTimeBase = 3;
        }
        else if (InGameManager.instance.score >= 12001)
        {
            spawnTimeBase = 1.5f;
        }
    }
}
