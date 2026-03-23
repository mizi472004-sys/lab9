using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;

    string path;

    void Awake()
    {
        instance = this;
        path = Application.persistentDataPath + "/save.json";
    }

    [System.Serializable]
    public class SaveData
    {
        public int level;
        public int score;
        public float timePlayed;
    }

    public void SaveGame()
    {
        SaveData data = new SaveData();
        data.level = GameManager.instance.level;
        data.score = GameManager.instance.score;
        data.timePlayed = GameManager.instance.timePlayed;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);

        Debug.Log("Saved at: " + path);
    }

    public void LoadGame()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            GameManager.instance.level = data.level;
            GameManager.instance.score = data.score;
            GameManager.instance.timePlayed = data.timePlayed;

            Debug.Log("Loaded!");
        }
        else
        {
            Debug.Log("No save file!");
        }
    }
}