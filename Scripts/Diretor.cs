using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imagemGameOver;
    private Aviao aviao;
    private Pontuacao pontuacao;
 void Start()
    {
      this.aviao = GameObject.FindObjectOfType<Aviao>();  
      this.pontuacao = GameObject.FindObjectOfType<Pontuacao>(); 
    }

    public void FinalizarJogo(){
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
    }

    public void ReiniciarJogo(){
        Time.timeScale = 1;
        imagemGameOver.SetActive(false);
        this.aviao.Reiniciar();
        this.DestruirObstaculos();
        this.pontuacao.ReiniciarPontuacao();
    }

    private void DestruirObstaculos(){
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
       foreach(Obstaculo obstaculo in obstaculos){
        obstaculo.Destruir(0.0f);
       }
    }
}
