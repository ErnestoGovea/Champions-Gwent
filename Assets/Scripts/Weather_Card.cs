using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather_Card : MonoBehaviour
{
    public string Name;
  //  public int Atk;
    public string Posicion_Fila;

      public MANOS manos;
    void Start()
    {
        manos = transform.parent.GetComponent<MANOS>();
    }

    public void OnMouseDown()
    {
        manos.Invocar_Weather_Card(this);
        
    }
}
