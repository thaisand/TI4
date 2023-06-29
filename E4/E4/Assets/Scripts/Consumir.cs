using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumir : MonoBehaviour
{
    public Text pontosTxt; 
    public Text velocidade; 
    private int pontos;
    private CapsuleMov capsuleMov; 
    private bool consumiuVelocidade;
    private float tempoConsumo;
    private float duracaoConsumo = 4f;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        capsuleMov = FindObjectOfType<CapsuleMov>(); // Atribui o componente CapsuleMov
    }

private void OnTriggerEnter(Collider collider)
{
    if (collider.CompareTag("pontos"))
    {
        pontos = pontos + 1;
        Destroy(collider.gameObject);
    }
    if (collider.CompareTag("velocidade"))
    {
        if (!consumiuVelocidade)
        {
            consumiuVelocidade = true;
            tempoConsumo = Time.time;
            if (capsuleMov != null)
            {
                capsuleMov.Speed = capsuleMov.Speed + 6;
            }
            Destroy(collider.gameObject);
        }
    }
}


    // Update is called once per frame
    void Update()
    {
        pontosTxt.text = "PONTOS:" + pontos.ToString();
        if (capsuleMov != null)
        {
            if (consumiuVelocidade)
            {
                if (Time.time - tempoConsumo >= duracaoConsumo)
                {
                    capsuleMov.Speed = capsuleMov.Speed - 6;
                    consumiuVelocidade = false;
                }
            }
            velocidade.text = "VELOCIDADE:" + capsuleMov.Speed.ToString();
        }
    }
}
