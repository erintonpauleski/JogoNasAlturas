using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    Rigidbody2D fisica;
    [SerializeField]
    int ValorImpulso = 10;
    void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            this.Impulsionar();
        }

        
    }

    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * ValorImpulso , ForceMode2D.Impulse);
    }
}
