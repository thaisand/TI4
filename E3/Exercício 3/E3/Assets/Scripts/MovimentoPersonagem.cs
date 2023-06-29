using UnityEngine;

public class MovimentoPersonagem : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidade;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(moveHorizontal, 0, moveVertical);
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //rb.AddForce(movement * velocidade);
    }
}
