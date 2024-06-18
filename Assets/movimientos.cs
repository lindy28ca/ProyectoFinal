using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientos : MonoBehaviour
{
    Rigidbody2D helado;
    public float velocidad;

    private void Awake()
    {
        helado = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        helado.velocity = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.D))
        {
            helado.velocity = new Vector2(velocidad,0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            helado.velocity = new Vector2(0, velocidad);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            helado.velocity = new Vector2(0, -velocidad);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            helado.velocity = new Vector2( -velocidad,0 );
        }
     
    }
}
