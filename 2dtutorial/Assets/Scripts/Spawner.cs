using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] float spawnRate = 2f;
    [SerializeField] float  PowerspawnRate = 2f;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] GameObject laserPrefab;
    float xMin;
    float xmax;
    float yspawn;
    // Start is called before the first frame update
    void Start()
    {
        xMin = Camera.main.ViewportToWorldPoint(new Vector3(.1f, 0, 0)).x;
        xmax = Camera.main.ViewportToWorldPoint(new Vector3(.9f, 0, 0)).x;
        yspawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y;

        InvokeRepeating("SpawnEnemy", 0, spawnRate);
        InvokeRepeating("SpawnBoost", 0, PowerspawnRate);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void SpawnEnemy()
    {
        float randx = Random.Range(xMin, xmax);
        Instantiate(enemyPrefab, new Vector3(randx, yspawn, 0), Quaternion.identity);
    }
    void SpawnBoost()
    {
        float randx = Random.Range(xMin, xmax);
        float randTime = Random.Range(1, 10);
        if(randTime >7)
        {
            Instantiate(laserPrefab, new Vector3(randx, yspawn, 0), Quaternion.identity);
        }
       
        
    }
}