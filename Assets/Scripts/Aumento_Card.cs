using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aumento_Card : MonoBehaviour
{
    
    public string Name;
    public string Posicion_Fila;
    //  public int Atk;

     public MANOS manos;
    void Start()
    {
        manos = transform.parent.GetComponent<MANOS>();
    }

    public void OnMouseDown()
    {
        manos.Invocar_Aumento_Card(this);
        
    }
//Hola Mindo
   
    
}
