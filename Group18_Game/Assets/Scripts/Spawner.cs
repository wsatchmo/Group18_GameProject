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

    /// <summary>
    /// Called at fixed intervals at the same rate as the physics system (50/frame).
    /// </summary>
    private void FixedUpdate()
    {
        PlayerShoot();
    }

    /// <summary>
    /// Handles instantiation of 
    /// </summary>
    private void PlayerShoot()
    {
        if (!delayBetweenShots)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0))
            {
                Debug.Log("Firing.");
                SpawnProjectile();
                StartCoroutine(WaitToReload());
                //rigidbody.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
            }
        }
    }

    //continually move in same direction
    //bullets are self-deleted after ten seconds

    /// <summary>
    /// Wait time before player can shoot again
    /// </summary>
    /// <returns></returns>
    IEnumerator WaitToReload()
    {
        delayBetweenShots = true;
        yield return new WaitForSeconds(0.75f);
        delayBetweenShots = false;
    }

    public void SpawnProjectile()
    {
        Rigidbody projectile = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        projectile.velocity = transform.TransformDirection(Vector3.forward * 100);
    }
}
