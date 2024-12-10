using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
 * Author: [Satcher, Will]
 * Date created: [12/10/2024]
 * Date edited: [12/10/2024]
 * [Handles UI for main scene]
 */

public class UIManager : MonoBehaviour
{
    //public Player playerStats;
    public TMP_Text timeText;
    public TMP_Text pointsText;

    // Update is called once per frame
    void Update()
    {
       timeText.text = "Time: "; //+ playerStats.lives;
       pointsText.text = "Points: "; //+ playerStats.coins;
    }
}
