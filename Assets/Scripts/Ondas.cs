using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondas : MonoBehaviour
{
   

    public comportamentometeoro prefabAsteroide;

    public int quantidadeAssteroide = 100;



    void Start()
    {
        for (int i = 0; i < quantidadeAssteroide; i++)
        {
<<<<<<< HEAD

            float  x = Random.Range(-11.0f, 11.0f); //222
            float  y = Random.Range(-5.0f, 5.0f);
=======
            float x = Random.Range(-11.0f, 11.0f);
            float y = Random.Range(-5.0f, 5.0f);
>>>>>>> b0e69563451d26f43c3adbd0e20c37889034cc94

            Vector3 posicao = new Vector3(0.0f,0.0f,0.0f);
            Instantiate(prefabAsteroide, posicao,Quaternion.identity);

        }

    }

    
}
