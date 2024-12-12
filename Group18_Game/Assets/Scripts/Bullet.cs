using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Player Player;
    public Spawner Gun;

    public int points;

    private void Start()
    {

    }

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
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "PowerSize")
        {
            Gun.bulletBig = true;
            other.gameObject.SetActive(false);
            //Gun.BulletResize();
            //Spawner gs = Gun.GetComponent<Spawner>();
            //gs.StartCoroutine(gs.BulletResize());

        }
    }



}
