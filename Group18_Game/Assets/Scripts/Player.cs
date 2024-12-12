using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: [Ben]
 * Date created: [12/6/2024]
 * Date edited: [12/10/2024]
 * [Handles player score and statuss]
 */


public class Player : MonoBehaviour
{

    //Timer for each level
    public int points;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    //Get points from bullet
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        ResetPoints();
        StartCoroutine(LevelOne());
    }

    private void ResetPoints()
    {
        points = 0;
    }

    public void AddPoints(int score)
    {
        points += score;
        Debug.Log("Player's Score: " + points);
    }

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
