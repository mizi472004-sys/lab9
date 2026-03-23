using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int level = 1;
    public int score = 0;
    public float timePlayed = 0f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        timePlayed += Time.deltaTime;
    }
    void OnApplicationQuit()
{
    SaveSystem.instance.SaveGame();
}
}