using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Text textoPontuacao;
    public int pontos = 0;
    private AudioSource audioPontuacao;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void AdicionarPontos(){

    this.pontos++;
    this.textoPontuacao.text = pontos.ToString();
    this.audioPontuacao.Play();
    
    }

 public void ReiniciarPontuacao(){
    this.pontos = 0;
    this.textoPontuacao.text = pontos.ToString();
 }
}
