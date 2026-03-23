using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;

    void Update()
    {
        scoreText.text = "Score: " + GameManager.instance.score;
        timeText.text = "Time: " + Mathf.FloorToInt(GameManager.instance.timePlayed);
    }
}