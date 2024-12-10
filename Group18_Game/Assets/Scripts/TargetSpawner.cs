using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Satcher, Will]
 * Date created: [12/8/2024]
 * Date edited: [12/9/2024]
 * [Handles spawning of prefab targets]
 */

public class TargetSpawner : MonoBehaviour
{
    public bool goingLeft;
    public float timeBetweenShots;
    public float startDelay;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectile", startDelay, timeBetweenShots);
    }


    public void SpawnProjectile()
    {
        GameObject projectile1 = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        if (projectile1.GetComponent<TargetBasic>())
        {
            projectile1.GetComponent<TargetBasic>().goingLeft = goingLeft;
        }        
        GameObject projectile2 = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        if (projectile2.GetComponent<TargetMid>())
        {
            projectile2.GetComponent<TargetMid>().goingLeft = goingLeft;
        }
        GameObject projectile3 = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        if (projectile3.GetComponent<TargetHard>())
        {
            projectile3.GetComponent<TargetHard>().goingLeft = goingLeft;
        }
        GameObject projectile4 = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        if (projectile4.GetComponent<PowerSize>())
        {
            projectile4.GetComponent<PowerSize>().goingLeft = goingLeft;
        }
        GameObject projectile5 = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        if (projectile5.GetComponent<PowerAmt>())
        {
            projectile5.GetComponent<PowerAmt>().goingLeft = goingLeft;
        }
    }



    //make spawners only spawn a certain amount
    // make it so that targets move in different ways configurable in unity ui
    // randomize speed and direction in some cases
    // make some zig-zag and some go straight; some go back and forth and some only go across
    // some should be close and some should be far away
    // make sure they count as hit targets, some count for different amounts
    // make sure there is a boundary where they disappear
    // players lose points if they hit birds
    // plan to configure what happens when shooting a power up (will be partly in player or bullet script)




}
