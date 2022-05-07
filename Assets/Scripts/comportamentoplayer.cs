    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoplayer : MonoBehaviour
{
    
    public float aceleracao = 1.0f;

    public float rotacao = 180.0f;
    
    public float velocidademaxima = 10.0f;
    public Rigidbody2D player;
    public float velocidadeProjetil = 3.0f;
    public Rigidbody2D jogadorRb;

     public Rigidbody2D projetoRb;

    void Start()
    {
        transform.position = new Vector3 (0.0f,0f,0f);
        
  
    void start()
    {
       


    }

    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(projetoRb,jogadorRb.position, Quaternion.identity);
            projetil.velocity = transform.up * velocidadeProjetil;


        }

        if(Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * aceleracao;
            player.AddForce(direcao, ForceMode2D.Force);

        }
        if (Input.GetKey(KeyCode.A))
        {
           player.rotation += rotacao * Time.deltaTime;  // player.rotation = player.rotation + (180.0f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
           player.rotation -= rotacao * Time.deltaTime;  // player.rotation = player.rotation + (180.0f * Time.deltaTime);

        }
        if(player.velocity.magnitude > velocidademaxima)
        {
            player.velocity = Vector2.ClampMagnitude(player.velocity, velocidademaxima);
        }

    }
    void OnTriggerEnter2D (Collider2D outro)
    {

        Destroy (gameObject);
    }
}
