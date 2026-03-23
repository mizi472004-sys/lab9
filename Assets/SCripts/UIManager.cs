using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panel;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

            panel.SetActive(isPaused);

            // Dừng / chạy game
            Time.timeScale = isPaused ? 0 : 1;
        }
    }
}