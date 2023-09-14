using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    float yposition;
    [SerializeField] GameObject laser; 
    void Start()
    {
        yposition = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(convertedPosition.x, yposition, 0);

        if(GameManager.instance.powerUp == true)
        {
            for(int i =0; i <3; i++)
            {
                Instantiate(laser, new Vector3(convertedPosition.x - (i),yposition, 0), Quaternion.identity);
                Instantiate(laser, new Vector3(convertedPosition.x + (i), yposition, 0), Quaternion.identity);
            }
            GameManager.instance.powerUp = false;
        }
        if (Input.GetButtonDown("FireLaser"))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
        
    }
}
