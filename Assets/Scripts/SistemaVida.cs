using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SistemaVida : MonoBehaviour
{
    public int maxVida = 100;
    public int vidaAtual;
    public TMP_Text txtVida;
    void Start()
    {
        vidaAtual = maxVida;
        AtualizaInterfaceVida();
    }

    void Update(){
        if (transform.position.y <= -15){
            RecebaDano(10);
        }
    }

    public void RecebaDano(int dano){
        vidaAtual = vidaAtual - dano;
        AtualizaInterfaceVida();
        transform.position = new Vector3(-6, -3, 0);
        if (vidaAtual <= 0){
            PerdeJogo();
        }
    }
    void PerdeJogo(){
        SceneManager.LoadScene("1 - Tutorial");
    }
    void AtualizaInterfaceVida(){
        if(txtVida.text != ""){
            txtVida.text = "Vida: " + vidaAtual.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Obstaculo")){
            RecebaDano(10);
        }
    }
}