using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.5f;
    public float valorMinimo = 0.0f;
    public float valorMaximo = 0.0f;
    private Vector3 posicaoDoAviao;
    private bool pontuei;
    Pontuacao pontuacao;

    void Start()
    {
     posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
     pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }
    void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(valorMinimo, valorMaximo));
    }
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        if(!pontuei && this.transform.position.x < posicaoDoAviao.x){
            Debug.Log("pontuou");
            pontuei = true;
            pontuacao.AdicionarPontos();
        }

        this.Destruir(5.0f);  
    }

    public void Destruir(float tempo){
        Destroy(this.gameObject,tempo);
    }
}
