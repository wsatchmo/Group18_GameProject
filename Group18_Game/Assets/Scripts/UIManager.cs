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

    public int points;

    public Player playerStats;
    public TMP_Text pointsText;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Points: " + playerStats.points;
    }

}
