using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

/*
* Author: [Satcher, William]
* Date Created: [12/6/2024]
* Date Edited: [12/8/2024]
* [Handles movement and behavior of all targets]
*/

public class TargetMovement : MonoBehaviour
{

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Detect collisions using a trigger event.
    /// </summary>
    /// <param name="other">The other object that triggered the collision.</param>
    ///
    /*
     

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            points++;
        }
        if (other.gameObject.tag == "Enemy")
        {
            Respawn();
        }
        if (other.gameObject.tag == "Laser")
        {
            StartCoroutine(Stun());
        }
        if (other.gameObject.tag == "Portal")
        {
            //Update the start position to the portal's spawn position
            startPos = other.gameObject.GetComponent<Portal>().spawnPoint.transform.position;
            transform.position = startPos;
        }
        if (other.gameObject.tag == "Deathberry")
        {
            other.gameObject.SetActive(false);
            Respawn();
        }
        if (other.gameObject.tag == "Bullet")
        {
            other.gameObject.SetActive(false);
            Respawn();
        }
        if (other.gameObject.tag == "Koopa")
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.5f))
            {
                if (hit.collider.gameObject.tag == "Koopa")
                {
                    Debug.Log("Kooper hit");
                    Destroy(other.gameObject);
                }
            }
            else
            {
                Respawn();
            }
        }
    }


    */

}
