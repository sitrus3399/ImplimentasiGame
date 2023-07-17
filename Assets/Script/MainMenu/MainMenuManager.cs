using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public TMP_Text highscoreText;
    public void Start()
    {
        //GameManager.instance.highscore = PlayerPrefs.GetInt("highscore");
        
        SaveManager.instance.LoadToJSon();
        highscoreText.text = "Highscore : " + GameManager.instance.highscore.ToString();
        Time.timeScale = 1;
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
