using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int points;

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
            points++;
        }
        if (other.gameObject.tag == "TargetMedium")
        {
            other.gameObject.SetActive(false);
            points += 3;
        }
        if (other.gameObject.tag == "TargetHard")
        {
            other.gameObject.SetActive(false);
            points += 5;
            //StartCoroutine(Stun());
        }
        if (other.gameObject.tag == "PowerAmt")
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "PowerSize")
        {
            other.gameObject.SetActive(false);
        }




       
    }

}
