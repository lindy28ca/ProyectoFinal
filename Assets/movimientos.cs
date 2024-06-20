using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientos : MonoBehaviour
{
    Rigidbody2D helado;
    public float velocidad;
    public cambiarescena cambiar;

    private void Awake()
    {
        helado = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        helado.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            helado.velocity = new Vector2(velocidad,0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            helado.velocity = new Vector2(0, velocidad);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            helado.velocity = new Vector2(0, -velocidad);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            helado.velocity = new Vector2( -velocidad,0 );
        }
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            cambiar.escenas("perdiste");
        }
    }
}
