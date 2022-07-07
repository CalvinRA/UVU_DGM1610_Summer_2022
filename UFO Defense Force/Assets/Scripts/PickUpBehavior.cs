using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehavior : MonoBehaviour
{
    public GameObject pickUp;
    public bool stopSpawn = false;
    public float spawnTime;
    public float spawnDelay;

    public void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    public void SpawnObject()
    {
        Instantiate(pickUp, transform.position, transform.rotation);
        if(stopSpawn)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
