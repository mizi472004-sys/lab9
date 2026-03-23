using UnityEngine;

public class GameController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed SPACE");

            GameManager.instance.score += 10;

            Debug.Log("Score: " + GameManager.instance.score);
        }
    }
}