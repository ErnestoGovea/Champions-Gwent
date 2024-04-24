using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Golden_Card : MonoBehaviour
{
    public string Name;
    public int Atk;
    public string Posicion_Fila;

    public MANOS manos;
    void Start()
    {
        manos = transform.parent.GetComponent<MANOS>();
    }

    public void OnMouseDown()
    {
        manos.Invocar_GoldCard(this);
        manos.ActualizarTextoSumaAtaque();
        
    }

}
