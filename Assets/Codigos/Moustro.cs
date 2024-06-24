using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Moustro : MonoBehaviour
{
    protected Rigidbody2D Moustros;
    protected float Posicion;
    protected Vector2 Direccion()
    {
        Posicion = 0;
        if (Posicion == 3)
        {
            Posicion = 0;
        }
        Vector2 Movi=new Vector2 (0,0); 
        if (Posicion == 0)
        {
            Movi = new Vector2(0, 1);
        }
        if (Posicion == 0)
        {
            Movi = new Vector2 (0, -1);
        }
        if (Posicion == 0)
        {
            Movi = new Vector2 (-1, 0);
        }
        if (Posicion == 0)
        {
            Movi= new Vector2 (1, 0);
        }
        ++Posicion;
        return Movi;
    }
}

