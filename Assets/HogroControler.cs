using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HogroControler : Moustro
{
    Rigidbody2D _rigidbody2D;
    BoxCollider2D _boxcollider2D;
    public float Speed = 1;
    int _xdirection = 1;
    int _ydirection = 1;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _boxcollider2D = GetComponent<BoxCollider2D>();
    }
    void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(Speed * _xdirection, 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        _xdirection *= -1;
    }
}
