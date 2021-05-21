using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallSpawner : MonoBehaviour
{ 

    public GameObject ballGameObject;
    public GameObject gameManagerGameObject;
    public float spawnTime;


    void Start() 
    {
        spawnTime = 1f;

        gameManagerGameObject = GameObject.Find("GameManager");
        
        Invoke("SpawnBall", spawnTime);
    }

    public void SpawnBall()
    {
        GameObject tempBall = Instantiate(ballGameObject, transform.position, transform.rotation);

        tempBall.GetComponent<Rigidbody>().AddForce(transform.forward * 800f);

        if (!gameManagerGameObject.GetComponent<GameController>().isGameOver) { 
            Invoke("SpawnBall", spawnTime); 
        }
    }

}



















