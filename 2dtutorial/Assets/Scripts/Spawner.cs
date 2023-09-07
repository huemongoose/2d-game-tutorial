using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnRate = 2f;
    [SerializeField] GameObject enemyPrefab;
    float xmin;
    float xmax;
    float yspawn;
    // Start is called before the first frame update
    void Start()
    {
        xmin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        xmax = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        yspawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y;
        InvokeRepeating("SpawnEnemy", 2f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, new Vector3(0, yspawn, 0), Quaternion.identity);
    }
}