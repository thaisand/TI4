using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMov : MonoBehaviour
{
    public float Speed = 0f;
    Rigidbody Rig;

    void Start() {
        Rig = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        Rig.velocity = movement * Speed;
    }

}
