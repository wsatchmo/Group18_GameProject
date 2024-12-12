using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
* Author: [Satcher, William]
* Date Created: [12/3/2024]
* Date Edited: [12/3/2024]
* [Handles Start Screen scene management]
*/

//CHANGE THIS TO A LEVEL CHOOSING SCREEN
//This and Game Over should allow players to choose level

public class StartUI : MonoBehaviour
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
