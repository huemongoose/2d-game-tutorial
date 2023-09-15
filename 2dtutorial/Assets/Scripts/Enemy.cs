using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speed = 10f;
    [SerializeField] GameManager manager;
    [SerializeField] GameObject enemylaser;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.instance.isGameover == false)
        {
            transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
            
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.instance.InitiateGameover();
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }
        if(collision.gameObject.tag == "Laser")
        {
            GameManager.instance.increasescore(10);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
    }
    
}
