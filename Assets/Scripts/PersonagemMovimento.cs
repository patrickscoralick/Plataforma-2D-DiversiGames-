using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemMovimento : MonoBehaviour
{
    public float velocidade = 10.5f;
    public Vector2 alturaPulo = new Vector2(0, 5);
    private float horizontal;
    public bool estaNoChao = false;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * velocidade * Time.deltaTime, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao == true){
            GetComponent<Rigidbody2D>().AddForce(alturaPulo, ForceMode2D.Impulse);
        }
    }
    void    OnCollisionEnter2D (Collision2D other) {
        if (other.gameObject.CompareTag("Plataforma")){
            estaNoChao = true;
        }
    }
    void    OnCollisionExit2D (Collision2D other) {
        estaNoChao = false;
    }
} 