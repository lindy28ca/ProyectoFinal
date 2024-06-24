using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class gamemanagercontrol : MonoBehaviour
{
    public puntoscontrol puntoscontrol;
    float puntos=0;
    public void Aumentar(float puntitos)
    {
        puntos = puntos+ puntitos;
        puntoscontrol.maspuntos(puntos);
    }

}
