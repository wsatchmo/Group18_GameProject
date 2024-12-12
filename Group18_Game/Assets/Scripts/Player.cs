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

    //keep score here
    //make a timer for each level [here or elsewhere???]
    public int points;
    private Vector3 startPos;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        StartCoroutine(LevelOne());
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
