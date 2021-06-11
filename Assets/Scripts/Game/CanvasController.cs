using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{

    public GameObject gameManagerGameObject;

    public Text pointsText;
    public Text livesText;
    public Text gameOverText;
    public Text nextLevelText;
    public Text crashedText;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerGameObject = GameObject.Find("GameManager");

        //timerText.gameObject.SetActive(true);
        pointsText.gameObject.SetActive(true);
        livesText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        nextLevelText.gameObject.SetActive(false);
        crashedText.gameObject.SetActive(false);
    }

    void Update()
    {

        pointsText.text = "Points: " +
            gameManagerGameObject.GetComponent<GameController>().points.ToString();
        livesText.text = "Life: " +
            gameManagerGameObject.GetComponent<GameController>().points.ToString();


        //Código do temporizador;
        if (gameManagerGameObject.GetComponent<GameController>().isGameOver)
        {
            //timerText.gameObject.SetActive(false);
            pointsText.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(true);

            gameOverText.text = "Game Over! /n Final Score: " +
                gameManagerGameObject.GetComponent<GameController>().points.ToString();
        }
        else
        {
            //timerText.text = gameManagerGameObject.GetComponent<GameController>().time.ToString();
            pointsText.text = gameManagerGameObject.GetComponent<GameController>().points.ToString();
        }
    }
}
