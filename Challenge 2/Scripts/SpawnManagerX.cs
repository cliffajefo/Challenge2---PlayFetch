using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    public int spawnInterval;
        

    // Start is called before the first frame update
    void Start()
    {
      

        Invoke("SpawnRandomBall", startDelay);

        // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);

    }


    void Update()
    {
        
        
    }


    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Randomize the balls 
        int ballindex = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballindex], spawnPos, ballPrefabs[ballindex].transform.rotation);

        //Using recurssion to call and update the function at random intervals
        Invoke("SpawnRandomBall", spawnInterval);
        spawnInterval = Random.Range(3, 5);

    }

}
