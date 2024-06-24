using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorControl : MonoBehaviour
{
    Rigidbody2D helado;
    public float velocidad;
    public cambiarescena cambiar;
    float horizontal;
    float vertical;
    private void Awake()
    {
        helado = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
       if(vertical == 0)
        {
            helado.velocity=new Vector2(horizontal*velocidad, 0);
        }
       if(horizontal == 0)
        {
            helado.velocity=new Vector2(0,vertical*velocidad);
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
