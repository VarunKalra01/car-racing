using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; 
    private bool isPaused = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle the pause state
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; 
        isPaused = false; 
    }

    // Method to pause the game
    public void Pause()
    {
        pauseMenuUI.SetActive(true); 
        Time.timeScale = 0f; 
        isPaused = true; 
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameStart");
    }

    // Method to restart the game
    public void RestartGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Game");
    }
}
