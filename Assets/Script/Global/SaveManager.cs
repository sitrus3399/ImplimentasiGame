using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    int highscore;
    Data dataJson;

    public void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void Start()
    {
        dataJson = new Data();
    }
    public void SaveToJSon()
    {
        dataJson.highscore = GameManager.instance.highscore;
        string dataYangDiInput = JsonUtility.ToJson(dataJson);
        File.WriteAllText(Application.persistentDataPath + "/save.json", dataYangDiInput);
    }

    public void LoadToJSon()
    {
        if(File.Exists(Application.persistentDataPath + "/save.json"))
        {
            string dataLoad = File.ReadAllText(Application.persistentDataPath + "/save.json");
            dataJson = JsonUtility.FromJson<Data>(dataLoad);
            GameManager.instance.highscore = dataJson.highscore;
        }
    }
}

[System.Serializable]
public class Data
{
    public int highscore;
}
