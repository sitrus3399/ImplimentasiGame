using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilihKarakterManager : MonoBehaviour
{
    public SOKarakter[] soKarakter;

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void DaniButton()
    {
        GameManager.instance.soKarakterManager = soKarakter[0];
        SceneManager.LoadScene(2);
    }

    public void LaniButton()
    {
        GameManager.instance.soKarakterManager = soKarakter[1];
        SceneManager.LoadScene(2);
    }

}
