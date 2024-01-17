using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculo : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar;

    private float cronometro;
    
    [SerializeField]
    private GameObject manualDeInstrucoes;

    private void Awake(){
        cronometro = tempoParaGerar;
    }
    void Update()
    {
        cronometro -= Time.deltaTime;
        if(cronometro < 0){
            GameObject.Instantiate(manualDeInstrucoes, transform.position, Quaternion.identity);            
            cronometro = tempoParaGerar;            
        }
        
    }
}
