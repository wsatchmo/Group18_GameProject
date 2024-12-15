using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool gameIsPaused = false; // track pause state

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle pause state on Escape key press
            gameIsPaused = !gameIsPaused;
            if (!gameIsPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    /// <summary>
    /// Pauses the game and activates the menu
    /// </summary>
    void PauseGame()
    {
        // Set Time.timeScale to 0 to pause gameplay
        Time.timeScale = 0;
        // Make PauseMenu panel visible (activate its gameObject)
        pauseMenuUI.SetActive(true);
    }

    /// <summary>
    /// Resumes the game and deactivates the menu
    /// </summary>
    public void ResumeGame()
    {
        // Set Time.timeScale back to 1 to resume gameplay
        Time.timeScale = 1;
        // Hide PauseMenu panel (deactivate its gameObject)
        pauseMenuUI.SetActive(false);
    }

    /// <summary>
    /// Change the current scene to the main menu scene
    /// </summary>
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
