using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSizeUp : MonoBehaviour
{
    public float speed;
    public bool goingUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Vector3.up * Time.deltaTime;
        Destroy(gameObject, 22);
    }
}
