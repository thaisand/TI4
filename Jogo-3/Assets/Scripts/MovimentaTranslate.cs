//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MovimentaTranslate : MonoBehaviour
{
    private float velocidade = 5.0f; // velocidade ajustável
    private Vector3 movimenta; 
    private Rigidbody fisica; 
    // Start is called before the first frame update
    void Start()
    {
        fisica = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        movimenta.x = Input.GetAxis("Horizontal");
        movimenta.y = Input.GetAxis("Vertical");
        movimenta.z = 0; 
        
        fisica.AddForce(movimenta * velocidade);
    }
}
