using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedspawned : MonoBehaviour
{
    public GameObject spawnee;
    public GameObject spawnee1;
    public GameObject spawnee2;
    public GameObject spawnee3;

    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    public float spawnCooldown = 1;
    private float timeUntilSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if(timeUntilSpawn <=0)
        {
            timeUntilSpawn = spawnCooldown;
            SpawnObject();
        }
    }
    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
       
    }
}
