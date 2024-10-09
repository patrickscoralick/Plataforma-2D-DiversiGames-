using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComportamento : MonoBehaviour
{
    public Transform personagem; //Referência ao personagem
    public Vector3 ajusteCamera; //Deslocamento da Camera em relação ao personagem
    public float CameraVelocidade = 0.125f; //Suavização da Câmera

    void FixedUpdate()
    {
        //Posição desejada da câmera (Personagem + deslocamento)
        Vector3 PosicaoDesejada = personagem.position + ajusteCamera;
        
        //Interpolação suave para a posição desejada
        Vector3 PosicaoSuavizada = Vector3.Lerp(transform.position, PosicaoDesejada, CameraVelocidade);

        //Define a nova posição da câmera
        transform.position = new Vector3(PosicaoSuavizada.x, PosicaoDesejada.y, transform.position.z);
    }
}