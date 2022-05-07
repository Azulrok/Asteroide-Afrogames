using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondas : MonoBehaviour
{
   

    public comportamentometeoro prefabAsteroide;

    public int quantidadeAssteroide = 3;



    void Start()
    {
        for (int i = 0; i < quantidadeAssteroide; i++)
        {
            Vector3 posicao = new Vector3(0.0f,0.0f,0.0f);
            Instantiate(prefabAsteroide, posicao,Quaternion.identity);

        }

    }

    
}
