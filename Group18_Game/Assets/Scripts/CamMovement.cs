using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Author: [Ben]
* Date Created: [11/22/2024]
* Date Edited: [12/3/2024]
* [Handles the camera object within the player]
*/
//vect 3, transform, bullet move forward, inputmousebutton0, attach this script to camera
public class CamMovement : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    public float bulletSpeed;
    public GameObject bulletPrefab; 

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update() //trigger in update getbuttondown
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);
        //s mouseLook.x = Mathf.Clamp(mouseLook.x, -90f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
    }

    //function create bullet and delay Instantiate,  if statement check if bullet has ridgebody = does not equal null 
    // bulletRb.AddForce = muliply vect3 with the shoot speed, 
    // ridgbody of bullet
    // if bullet does not equal null statement
    //||
    //\/
    //bulletRb.AddForce(vect3 * shootspeed, ForceMode.Impulse);
}
