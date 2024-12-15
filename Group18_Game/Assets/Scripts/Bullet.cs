using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Satcher, Will]
 * Date created: [12/10/2024]
 * Date edited: [12/15/2024]
 * [Handles UI for main scene]
 */

public class Bullet : MonoBehaviour
{

    public Player Player;
    //public Spawner Gun;

    public GameObject Gun;

    public int points;

    //continually move in same direction
    //bullets are self-deleted after five seconds
    private void Update()
    {
        DestroyObjectDelayed();
    }

    /// <summary>
    /// Bullet is destroyed five seconds after it spawns
    /// </summary>
    private void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 5);
    }

    /// <summary>
    /// Detect collisions using a trigger event.
    /// </summary>
    /// <param name="other">The other object that triggered the collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TargetBasic")
        {
            other.gameObject.SetActive(false);
            Player.AddPoints(5);
        }
        if (other.gameObject.tag == "TargetMedium")
        {
            other.gameObject.SetActive(false);
            Player.AddPoints(10);
        }
        if (other.gameObject.tag == "TargetHard")
        {
            other.gameObject.SetActive(false);
            Player.AddPoints(15);
            //StartCoroutine(Stun());
        }
        if (other.gameObject.tag == "PowerAmt")
        {
            Gun = this.transform.parent.gameObject;
            var GunScript = Gun.GetComponent<Spawner>();
            GunScript.BulletAmt();
            Debug.Log(Gun);
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "PowerSize")
        {
            Gun = this.transform.parent.gameObject;
            var GunScript = Gun.GetComponent<Spawner>();
            GunScript.BulletResize();
            Debug.Log(Gun);
            other.gameObject.SetActive(false);

        }
    }
}
