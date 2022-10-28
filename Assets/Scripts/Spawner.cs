using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject thingToSpawn;
    private Rigidbody rb;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public float xVectorMin;
    public float xVectorMax;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        GameObject spawnedThing = Instantiate(thingToSpawn, transform.position, transform.rotation);
        Rigidbody spawnedRb = spawnedThing.GetComponent<Rigidbody>();

        spawnedRb.velocity = new Vector3(Random.Range(xVectorMin,xVectorMax), Random.Range(-5f,5f), Random.Range(-10f,10f));
        spawnedRb.useGravity = true;
        
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(Random.Range(0, 15f), Random.Range(-5f, 7f), Random.Range(-5f, 7f));
    }
}
