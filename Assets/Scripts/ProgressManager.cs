using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ProgressManager : MonoBehaviour
{
    [System.Serializable]
    public class PlayerData
    {
        public int currentLevel = 1;
        public List<string> unlockedExtras = new List<string>();
        public List<string> completedEndings = new List<string>();
    }

    public PlayerData myData = new PlayerData();
    private string savePath;

    void Awake()
    {
        savePath = Application.persistentDataPath + "/save.json";
        LoadProgress();
    }

    public void SaveProgress()
    {
        string json = JsonUtility.ToJson(myData, true);
        File.WriteAllText(savePath, json);
        Debug.Log("Saved progress to: " + savePath);
    }

    public void LoadProgress()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            myData = JsonUtility.FromJson<PlayerData>(json);
            Debug.Log("Game loaded successfully");
        }
        else
        {
            SaveProgress();
            Debug.Log("No save file found, starting fresh");
        }
    }

    public void CompleteEnding(string endingName)
    {
        if (!myData.completedEndings.Contains(endingName))
        {
            myData.completedEndings.Add(endingName);
            SaveProgress();
            Debug.Log("Ending completed: " + endingName);
        }
    }

    public void UpdateLevel(int level)
    {
        myData.currentLevel = level;
        SaveProgress();
        Debug.Log("Updated current level to: " + level);
    }

    public bool HasCompletedEnding(string endingName)
    {
        return myData.completedEndings.Contains(endingName);
    }
}
