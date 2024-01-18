using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    private float ValorImpulso = 3.0f;

    private Diretor diretor;
    private Vector3 posicaoInicial;

    void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>();
        //this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    void Start()
    {
      this.diretor = GameObject.FindObjectOfType<Diretor>();  
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Debug.Log("Subindo");
            this.Impulsionar();
        }
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * ValorImpulso , ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }

    public void Reiniciar(){
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
