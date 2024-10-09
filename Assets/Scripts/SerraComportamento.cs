using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerraComportamento : MonoBehaviour
{
    public float velocidadeMovimento = 2.0f;
    public float distanciaMovimento = 3.0f;
    private Vector3 posicaoInicial;
    private bool moverDireita = true;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    void Update()
    {
        if(moverDireita == true){
            transform.position += new Vector3(1,0,0) * velocidadeMovimento * Time.deltaTime;
            if(transform.position.x >= posicaoInicial.x + distanciaMovimento){
                moverDireita = false;
            }
        }

        if(moverDireita == false) {
            transform.position += new Vector3(-1,0,0) * velocidadeMovimento * Time.deltaTime;
            if(transform.position.x <= posicaoInicial.x - distanciaMovimento){ 
                moverDireita = true;
            }
        }


        
    }
}
