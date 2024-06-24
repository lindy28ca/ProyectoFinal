using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControl : MonoBehaviour
{
    public GameObject Jugador;
    private void Update()
    {
        transform.position = new Vector3(Jugador.transform.position.x, Jugador.transform.position.y, -10);
    }
}
