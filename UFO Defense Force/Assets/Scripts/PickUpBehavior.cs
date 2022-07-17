using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehavior : MonoBehaviour
{
    public GameObject pickUp;
    public bool stopSpawn = false;
    public float spawnTime;
    public float spawnDelay;

    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomPowerUp", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void SpawnRandomPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(pickUp, spawnPos, pickUp.transform.rotation); //Spawns pickUp from array at a random location on the x axis
    }
}
