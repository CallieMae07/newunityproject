using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    //create a public array of objects to spawn, we will fll this up using the unity editor
    public GameObject[] objectToSpawn;

    float timeToNextSpawn; //tracks how long we should wait before spawning a new object
    float timeSinceLastSpawn = 0.0f; //tracks the time since we last spawned something

    public float minSpawnTime = 0.5f; //minimum amount of time between spawning objects
    public float maxSpawnTime = 3.0f; //maximum amount of time between spawning objects

    void Start()
    {
        //random.range returns a random float between two values
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {
        //add Time.deltaTime returns the amount of time passed since the last frame
        //this will create a float that counts up in senconds
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        //if we're counted past the amount of time we need to wait
        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            //use random.range to pick a number between 0 and the amount of itemswe have on our object list
            int selection = Random.Range(0, objectToSpawn.Length);

            //instantiate spawns a gameobject - in this casewe can tell it to spawn a game obejct from our object to spawn list
            //the second parameter in the brackets tells it where to spawn, so weve entered the position of the spawner
            //the third parameter is for rotation, and quaternion.identity means no rotation
            Instantiate(objectToSpawn[selection], transform.position, Quaternion.identity);

            //after spawning, we select a new random time for the next spawn and set our timer back to zero
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;



        }
    }
}
