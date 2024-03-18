using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;
    public int highScore = 0;

    void Awake() {
        if(Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public class HighScoreData {
        public int highScore;
    }

    public void SaveHighScore() {

        HighScoreData newHighScore = new HighScoreData();
        newHighScore.highScore = highScore;

        string json = JsonUtility.ToJson(newHighScore);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore() {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path)) {
            string json = File.ReadAllText(path);
            HighScoreData newHighScore = JsonUtility.FromJson<HighScoreData>(json);
            highScore = newHighScore.highScore;
        }
    }
}
