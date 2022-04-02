using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 
    public float speed ;

    public GameObject meteoro;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
          if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);
        }
         if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(speed, 0.0f * Time.deltaTime, 0.0f);
        }
          if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(-speed, 0.0f * Time.deltaTime, 0.0f);
        }


        if (Input.GetKey(KeyCode.Space))
        {
          Instantiate(meteoro,new Vector3(3.0f,3.0f,0.0f),Quaternion.identity);
        }
        

    }
}
