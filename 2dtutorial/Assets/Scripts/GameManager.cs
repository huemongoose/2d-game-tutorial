using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public static GameManager instance;
    public Boolean isGameover = false;
    public Boolean powerUp = false;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameOverText;
    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && isGameover)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    public void increasescore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score; 
    }
    public void InitiateGameover()
    {
        isGameover = true;
        gameOverText.SetActive(true);

    }
}
