using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLaser : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float elaserspeed = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, elaserspeed, 0) * Time.deltaTime;
    }
}
