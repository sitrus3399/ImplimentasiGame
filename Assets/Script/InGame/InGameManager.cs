using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameManager : MonoBehaviour
{
    public Character character;
    public GameObject gameOverPanel;
    public static InGameManager instance;
    public int score;
    public TMP_Text scoreText;
    public TMP_Text healthText;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public void Start()
    {
        Time.timeScale = 1;
        scoreText.text = "Score : 0";
    }
    public void PauseButton()
    {
        if(Time.timeScale == 0)
        { 
            Time.timeScale = 1;
        }
        else if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
    }

    public void GotScore(int poin)
    {
        score += poin;
        scoreText.text = "Score : " + score;
    }

    public void GotDamage()
    {
        character.currentHealth -= 1;
        healthText.text = "Health : " + character.currentHealth.ToString();
        if (character.currentHealth <= 0)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            if (score >= GameManager.instance.highscore)
            {
                GameManager.instance.highscore = score;
                //PlayerPrefs.SetInt("highscore", GameManager.instance.highscore);
                SaveManager.instance.SaveToJSon();
            }
        }
    }

    public void RestartButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void MainMenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
