using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spawns;
    float timeBtwSpawns = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
        timeBtwSpawns -= Time.deltaTime;
        if (timeBtwSpawns <= 0)
        {
            timeBtwSpawns = Random.Range(1, 3);
            Vector2 spawnposition = new Vector2();
            spawnposition.x = Random.Range(-2.5f, 2.5f);
            spawnposition.y = Random.Range(-7f, -7f);
            Instantiate(spawns[Random.Range(0, spawns.Length)], spawnposition, Quaternion.identity);
        }
    }
}
