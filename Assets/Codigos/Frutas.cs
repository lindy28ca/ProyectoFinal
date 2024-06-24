using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    public float Puntos;
    public gamemanagercontrol control;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            control.Aumentar(Puntos);
            Destroy(this.gameObject);
        }
    }
}
