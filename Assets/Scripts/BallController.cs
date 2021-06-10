using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public GameObject gameManagerGameObject;

    void Start()
    {
        gameManagerGameObject = GameObject.Find("GameManager");

        Invoke("BallDestroy", 5f);
    }

    public void BallDestroy()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Target")
        {                         
            gameManagerGameObject.GetComponent<GameController>().points++; 

            BallDestroy();
        }
    }
}
