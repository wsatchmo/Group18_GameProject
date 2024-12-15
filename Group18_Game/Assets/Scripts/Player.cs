using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

/*
 * Author: [Ben]
 * Date created: [12/6/2024]
 * Date edited: [12/10/2024]
 * [Handles player score and statuss]
 */


public class Player : MonoBehaviour
{

    public int points;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;

    GameObject Gun;

    public Spawner Spawner;
    public bool bulletBig = false;
    public bool bulletSpray = false;


    // Start is called before the first frame update
    void Start()
    {
        ResetPoints();
        StartCoroutine(LevelOne());
        Gun = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
        Debug.Log(Gun);
    }

    //Resets points to 0
    private void ResetPoints()
    {
        points = 0;
    }

    //Scoring system
    public void AddPoints(int score)
    {
        points += score;
        Debug.Log("Player's Score: " + points);
    }

    //public void BulletResize()
    //{
    //        StartCoroutine(PowerUpResize());
    //}
    //IEnumerator PowerUpResize()
    //{
    //    Spawner.BulletResize();
    //    yield return new WaitForSeconds(5f);
    //    bulletBig = false;
    //}

    public void BulletAmt()
    {
        Spawner.BulletAmt();
    }

    //Timer for each level
    IEnumerator LevelOne()
    {
        yield return new WaitForSeconds(36f);
        transform.position = spawnPoint2.transform.position;
        StartCoroutine(LevelTwo());
    }

    IEnumerator LevelTwo()
    {
        yield return new WaitForSeconds(30f);
        transform.position = spawnPoint3.transform.position;
        StartCoroutine(LevelThree());
    }

    IEnumerator LevelThree()
    {
        yield return new WaitForSeconds(38f);
        transform.position = spawnPoint4.transform.position;
        StartCoroutine(LevelFour());
    }

    IEnumerator LevelFour()
    {
        yield return new WaitForSeconds(28f);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }


}
