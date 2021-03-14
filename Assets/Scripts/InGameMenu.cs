using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;


public class InGameMenu : MonoBehaviour
{
    public GameData data;
    public string file = "gameData.txt";


    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject[] targets;
    private bool isPaused = false;

    
    public void SaveData()
    {
        string json = JsonUtility.ToJson(data);
        WriteToFile(file, json);
    }
    
    
    public void LoadData()
    {
        data = new GameData();
        string json = ReadFromFile(file);
        JsonUtility.FromJsonOverwrite(json, data);

    }
    
    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);

        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }

        else
        {
            Debug.LogWarning("File not found!");
            return "";
        }
    }


    private void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter (fileStream))
        {
            writer.Write(json);
        }
    }
    
    private string GetFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }
    
    
    
    
    
    
    
    void Start()
    {
        menu.SetActive (false);
    }

    public void Pause()
    {
        menu.SetActive(true);
       //Cursor.visible = true;
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Unpause()
    {
        menu.SetActive(false);
        //Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
    }

    public bool IsGamePaused()
    {
        return isPaused;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }
        }
    }

    public void NewGame()
    {
        Unpause();
        SceneManager.LoadScene("Menu");
    }


}
