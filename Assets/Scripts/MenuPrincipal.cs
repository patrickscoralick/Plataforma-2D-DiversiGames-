using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void ComecarJogo(){
        SceneManager.LoadScene("1 - Tutorial");
    }

    public void FecharJogo(){ 
        Debug.Log("FECHAR O JOGO");
        Application.Quit();
    }
}
