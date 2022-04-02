using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 
    public float speedVertical;

    public float speedHorizontal;


    public GameObject meteoro;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, speedVertical * Time.deltaTime, 0.0f);
        }
          if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f, -speedVertical * Time.deltaTime, 0.0f);
        }
         if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speedHorizontal * Time.deltaTime , 0.0f , 0.0f);
        }
          if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-speedHorizontal * Time.deltaTime, 0.0f ,0.0f);
        }
    }
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(meteoro, new Vector3(3.0f, 3.0f, 0.0f), Quaternion.identity);
        }
    }
}
