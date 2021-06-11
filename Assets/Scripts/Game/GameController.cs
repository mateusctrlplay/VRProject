using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public bool isGameOver;
    public int lives;
    public int points;
    public int currentLevel;
    public float time; 
    

    public GameObject canvasGameObject;
    public GameObject placeholderObject;
    public GameObject spaceshipGameObject;

    public Vector3 spaceshipStartPosition;

    public GameObject level1StartGameObject;
    public GameObject level2StartGameObject;
    public GameObject level3StartGameObject;

    void Start()
    {
        lives = 4;
        isGameOver = false;
        points = 0;
        time = 30;
        currentLevel = 1;

        canvasGameObject = GameObject.Find("Canvas");
        placeholderObject = GameObject.Find("Placeholder");
        spaceshipGameObject = GameObject.Find("Spaceship");

        spaceshipStartPosition = spaceshipGameObject.transform.position;

        level1StartGameObject = GameObject.Find("level1Start");
        level2StartGameObject = GameObject.Find("level2Start");
        level3StartGameObject = GameObject.Find("level3Start");
    }

    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            isGameOver = true;
        }
    }

    public void Destroyed()
    {
        
    }

    public void NextLevel()
    {

    }

    public void ChangeLevel()
    {

    }

    public void RestartGame()
    {

    }
}
