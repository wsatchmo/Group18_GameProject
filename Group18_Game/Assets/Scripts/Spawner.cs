using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Satcher, Will]
 * Date created: [12/8/2024]
 * Date edited: [12/8/2024]
 * [Handles spawning of bullets]
 */

public class Spawner : MonoBehaviour
{
    private bool delayBetweenShots = false;
    public Rigidbody projectilePrefab;
    public Rigidbody projectilePrefabBig;
    public Rigidbody projectileToSpawn;

    public Transform parent;

    //Powerups
    public bool bulletBig = false;
    public bool bulletAmt = false;

    public Player Player;

    /// <summary>
    /// Called at fixed intervals at the same rate as the physics system (50/frame).
    /// </summary>
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
        {
            if (!delayBetweenShots || bulletAmt)
            {
                //Debug.Log("Firing.");
                SpawnProjectile();
                StartCoroutine(WaitToReload());
                //rigidbody.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
            }
        }
    }

    private void Update()
    {
        
    }


    /// <summary>
    /// Wait time before player can shoot again
    /// </summary>
    /// <returns>cooldown</returns>
    IEnumerator WaitToReload()
    {
        delayBetweenShots = true;
        yield return new WaitForSeconds(0.75f);
        delayBetweenShots = false;
    }

    /// <summary>
    /// Change bullet size
    /// </summary>
    public void BulletResize()
    {
        StartCoroutine(PowerUpResize());
    }

    IEnumerator PowerUpResize()
    {
        bulletBig = true;
        yield return new WaitForSeconds(5f);
        bulletBig = false;
    }    

    /// <summary>
    /// Remove cooldown temporarily
    /// </summary>
    public void BulletAmt()
    {
        StartCoroutine(PowerUpAmt());
    }

    IEnumerator PowerUpAmt()
    {
        bulletAmt = true;
        yield return new WaitForSeconds(5f);
        bulletAmt = false;
    }

    public void SpawnProjectile()
    {
        if (!bulletBig)
        {
            Rigidbody projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation, parent);
            projectile.velocity = transform.TransformDirection(Vector3.forward * 100);
        } 
        else
        {
            Rigidbody projectile = Instantiate(projectilePrefabBig, transform.position, projectilePrefabBig.transform.rotation, parent);
            projectile.velocity = transform.TransformDirection(Vector3.forward * 100);
        }

        
    }
}
