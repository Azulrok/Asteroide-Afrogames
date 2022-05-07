using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 
    public float speedVertical;

    public float speedHorizontal;

    public Rigidbody2D jogadorRb;

     public Rigidbody2D projetoRb;

    public GameObject meteoro;

    public float velocidadeProjetil = 3.0f;

    void start()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(projetoRb,jogadorRb.position, Quaternion.identity);
            projetil.velocity = transform.up * velocidadeProjetil;


        }


    }


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
