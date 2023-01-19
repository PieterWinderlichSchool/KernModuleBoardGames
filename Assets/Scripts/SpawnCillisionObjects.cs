using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class SpawnCillisionObjects : MonoBehaviour
{

    public GameObject hurdleObjectToSpawn;

    public List<Vector3> spawnLocations = new List<Vector3>();
    
    [Range(5,10)]
    public int maxChanceToSpawnObject;
    // Start is called before the first frame update
    void Start()
    {

        int randomNumbrero = (int) Mathf.Floor(Random.Range(0, maxChanceToSpawnObject));
        if (randomNumbrero < maxChanceToSpawnObject - (maxChanceToSpawnObject / 2))
        {
            int randomNumbrero1 = (int) Mathf.Floor(Random.Range(0f, 3));
            GameObject newObstacle = Instantiate(hurdleObjectToSpawn,Vector3.zero, Quaternion.identity, this.transform);
            newObstacle.transform.localPosition = spawnLocations[randomNumbrero1];
            int randomNumbrero2 = (int) Mathf.Floor(Random.Range(0f, 2));
            newObstacle.GetComponent<OnPickup>().ceatePickup(randomNumbrero2);
        }
       
    }
}
