using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValues;
    public int spawnCount;

    void Start()
    {
        SpawnWaves();
    }

    void SpawnWaves()
    {
        for (int i = 0; i < spawnCount; i++) 
        {
            Vector3 spawnPosition = new Vector3
            (Random.Range(-spawnValues.x, spawnValues.y),
            spawnValues.y, spawnValues.z);
            //This quaternion corresponds to "no rotation" - the object is perfectly aligned with the world or parent axes.
            Quaternion spawnRotaiton = Quaternion.identity;
            Instantiate(hazard, spawnPosition, spawnRotaiton);
        }
        
    }
}
