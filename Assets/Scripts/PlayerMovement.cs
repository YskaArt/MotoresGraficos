using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 inputControl;
    public float MinSpeed;
    public float Speed;
    public float MaxSpeed;
    public float JumpPower;
    public Rigidbody Jugador;
    private bool CanJump;
    public float fallMultiplier = 2.5f;
    [SerializeField] private GameObject Gameover;
    private void Awake()
    {
        Gameover.SetActive(false);
    }
    void Update()
    {
        Speed = MinSpeed;
        inputControl.x = Input.GetAxis("Horizontal");
        inputControl.y = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.LeftShift))
        {
            Speed = MaxSpeed;
        }
        else
        {
            Speed = MinSpeed;

        }
        

        if (inputControl.x != 0.0f || inputControl.y != 0.0f)
        {
            Vector3 dir = transform.forward * inputControl.y + transform.right * inputControl.x;

            Jugador.MovePosition(transform.position + dir * Speed * Time.deltaTime);

        }
        if (CanJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jugador.velocity = new Vector3(Jugador.velocity.x, JumpPower, Jugador.velocity.z);
                CanJump = false;
            }
        }
        if (Jugador.velocity.y < 0)
        {
            Jugador.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        { 
            CanJump = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 0f;
            Gameover.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Meta"))
        {
            SceneManager.LoadScene(1);

        }
    }
    public void Reiniciar()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void Salir()
    {
        Application.Quit();

    }

}
