using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 inputControl;
    public float Speed;
    public float JumpPower;
    public Rigidbody Jugador;
    private bool CanJump;
    void Update()
    {
        inputControl.x = Input.GetAxis("Horizontal");
        inputControl.y = Input.GetAxis("Vertical");

        Jugador.AddForce(inputControl.x * Speed, 0f, inputControl.y * Speed, ForceMode.Impulse);
        
        if (CanJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jugador.AddForce(0f, JumpPower, 0f, ForceMode.Impulse);
                CanJump = false;
            }
        }
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        { 
            CanJump = true;
        }

    }
}
