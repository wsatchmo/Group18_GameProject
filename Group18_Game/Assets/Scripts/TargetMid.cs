using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Satcher, Will]
 * Date created: [12/8/2024]
 * Date edited: [12/8/2024]
 * [Handles spawning of prefabs]
 */

public class TargetMid : MonoBehaviour
{
    [Header("Projectile Variables")]
    public float speed;
    public bool goingLeft;

    // Update is called once per frame
    void Update()
    {
        if (goingLeft == true)
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
        else
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }

        Destroy(gameObject, 5);
    }
}
