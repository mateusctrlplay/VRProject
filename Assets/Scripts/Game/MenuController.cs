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
        changeDifficultyUI.SetActive(false);
        mainMenuUI.SetActive(true);

        PlayerPrefs.SetFloat("shipspeed", 5);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
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
