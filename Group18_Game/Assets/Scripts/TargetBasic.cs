using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Ben]
 * Date created: [12/8/2024]
 * Date edited: [12/8/2024]
 * [Handles spawning of target prefabs]
 */

public class TargetBasic : MonoBehaviour
{

    [Header("Projectile Variables")]
    public float speed;
    public bool goingLeft;

    // Update is called once per frame
    void Update()
    {
        if (goingLeft)
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
        else
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }

        Destroy(gameObject, 15);
    }
}
