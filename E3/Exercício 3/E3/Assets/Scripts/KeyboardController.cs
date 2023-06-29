using UnityEngine;

public class KeyboardController : MonoBehaviour
{
    public float speed = 5f; // velocidade de movimento do personagem

    void Update()
    {
        // movimento para frente e para trás
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * verticalInput * speed * Time.deltaTime;
        transform.position += movement;

        // movimento para os lados
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 sideMovement = transform.right * horizontalInput * speed * Time.deltaTime;
        transform.position += sideMovement;
    }
}
