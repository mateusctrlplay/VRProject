using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject mainMenuUI;
    public GameObject changeDifficultyUI;

    void Start()
    {
        changeDifficultyUI.SetActive(false); //Oculta os botões de mudar dificuldade
        mainMenuUI.SetActive(true); //mostra os botões de Play e Difficulty

        PlayerPrefs.SetFloat("shipspeed", 5); //salva a velocidade da nave
    }

    //Função a ser execultada pelo StartButton, quando apertar ele
    public void StartGame()
    {
        SceneManager.LoadScene("Game"); //Muda para a cena "Game"
    }

    public void ChangeDifficulty()
    {
        changeDifficultyUI.SetActive(true); //Mostra os botões de mudar dificuldade
        mainMenuUI.SetActive(false); //Oculta os botões de Play e Difficulty
    }

    public void DifficultyEasy()
    {
        PlayerPrefs.SetFloat("shipspeed", 5);

        changeDifficultyUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void DifficultyMedium()
    {
        PlayerPrefs.SetFloat("shipspeed", 10);

        changeDifficultyUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void DifficultyHard()
    {
        PlayerPrefs.SetFloat("shipspeed", 15);

        changeDifficultyUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
}
