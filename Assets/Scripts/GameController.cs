using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int points;
    public float time; 
    public bool isGameOver; //true false // verdeiro Falso

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        points = 0;
        time = 30;
    }

    // Update is called once per frame
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
}
