using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudControl : MonoBehaviour
{
    public GameObject cloud;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(cloud.GetComponent<Transform>().position.x > 5)
        {
            cloud.GetComponent<Transform>().position -= new Vector3(10, 0, 0);
        }
        cloud.GetComponent<Transform>().position +=  new Vector3(speed, 0, 0);
    }
}
