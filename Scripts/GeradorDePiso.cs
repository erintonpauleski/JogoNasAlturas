using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDePiso : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    private Vector3 posicaoInicial;
    private float tamanhoRealImagem;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoRealImagem = tamanhoImagem * escala;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(velocidade * Time.time, this.tamanhoRealImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
