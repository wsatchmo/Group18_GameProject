using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
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
}
