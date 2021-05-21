using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{

    public GameObject gameManagerGameObject;
    public Text timerText;
    public Text pointsText;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        timerText.gameObject.SetActive(true);
        pointsText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerGameObject.GetComponent<GameController>().isGameOver)
        {
            timerText.gameObject.SetActive(false);
            pointsText.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(true);

            gameOverText.text = "Game Over! /n Final Score: " +
                gameManagerGameObject.GetComponent<GameController>().points.ToString();
        }
        else
        {
            timerText.text = gameManagerGameObject.GetComponent<GameController>().time.ToString();
            pointsText.text = gameManagerGameObject.GetComponent<GameController>().points.ToString();
        }
    }
}
