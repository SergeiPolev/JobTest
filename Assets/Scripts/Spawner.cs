using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnRate = 1f;

    private float nextSpawn;

    private void Start()
    {
        nextSpawn = Time.time + nextSpawn;
    }

    private void Update()
    {
        if (nextSpawn <= Time.time)
        {
            Instantiate(objectPrefab, transform.position, Quaternion.identity);
            nextSpawn = Time.time + spawnRate;
        }
    }
}
