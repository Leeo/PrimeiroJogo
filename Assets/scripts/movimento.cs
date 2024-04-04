using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * 50);
        }

        // Rest of the code...
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,1) * Time.deltaTime * 50);
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-1) * Time.deltaTime * 50);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * 50);
        }  

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1,0,0) * Time.deltaTime * 50);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0,1,0) * Time.deltaTime * 50);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 50);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 50);
        }
    }
}
