using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
* Author: [Satcher, William]
* Date Created: [12/3/2024]
* Date Edited: [12/3/2024]
* [Handles Game Over scene management]
*/

//CHANGE TO BE A SCORE DISPLAY PAGE (we dont really have game over)
//This and Start should allow players to choose level

public class GameOverUI : MonoBehaviour
{
    /// <summary>
    /// Change the current scene based on the sceneIndex
    /// </summary>
    /// <param name="sceneIndex">Index of the scene being called</param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Debug.Log("Back to game");
    }

    /// <summary>
    /// Quits the game
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit.");
    }
}
