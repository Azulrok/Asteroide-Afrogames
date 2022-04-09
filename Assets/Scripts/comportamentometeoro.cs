using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentometeoro : MonoBehaviour
{
    public Rigidbody2D asteroidRb;
    public float velocidademaxima = 1.0f;


    // Start is called before the first frame update
    void Start()
    {

        Vector2 direcao = Random.insideUnitCircle;
        direcao = direcao * velocidademaxima;
        asteroidRb.velocity = direcao;
    



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
