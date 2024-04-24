using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MANOS : MonoBehaviour
{
    public List<GameObject> ZONAS = new List<GameObject>();
    public List<GameObject> Cards_In_Hand = new List<GameObject>();

     public TextMeshProUGUI Marcador; // Referencia al objeto TextMeshPro que mostrará la suma de los puntos de ataque

    public DECKS Mazo;

   // public MANOS Hand;

   //esto es para el jugador 1
    public Ataque AttackController;
    public Distancia DistanciaController;
    public Asedio AsedioController;
    public Clima ClimaController;
    public Aumento AumentoController;
    

     public new bool[] posicionesOcupadas_Ataque = new bool[5];
     public new bool[] posicionesOcupadas_Distancia = new bool[5];
     public new bool[] posicionesOcupadas_Asedio = new bool[5];
     public static new bool[] posicionesOcupadas_Clima = new bool[3];
     public new bool[] posicionesOcupadas_Aumento = new bool[3];
     public new bool[] posicionesOcupadas_Despeje = new bool[5];

    public bool Turno; //esto es para saber si estoy o no en mi turno
    public bool paso_Ronda;
    public bool Posibilidad_de_Convocar;

     public static int ronda =1;
     public int Rondas_GANADAS = 0;

     public int cartas_Jugadas = 0;


   // eesta es para las posiciones donde iran las cartas aumento segun su fila
 
    //esto es para el jugador 2



   // Pra jugador 1 
    public void Invocar_GoldCard(Golden_Card CartaOro)
    {
        if(CartaOro.Posicion_Fila == "Cuerpo a Cuerpo")
        {
            for(int i = 0; i < posicionesOcupadas_Ataque.Length; i++)
            {
                if(posicionesOcupadas_Ataque[i] == false)
                {
                    CartaOro.transform.position = AttackController.position_ataque_fila[i].transform.position;
                    AttackController.Cartas_Fila_Ataque.Add(CartaOro.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaOro.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Ataque[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

        else if(CartaOro.Posicion_Fila == "Distancia")
        {
             for(int i = 0; i < posicionesOcupadas_Distancia.Length; i++)
            {
                if(posicionesOcupadas_Distancia[i] == false)
                {
                    CartaOro.transform.position = DistanciaController.position_distancia_fila[i].transform.position;
                    DistanciaController.Cartas_Fila_Distancia.Add(CartaOro.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaOro.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Distancia[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

         else if(CartaOro.Posicion_Fila == "Asedio")
        {
             for(int i = 0; i < posicionesOcupadas_Asedio.Length; i++)
            {
                if(posicionesOcupadas_Asedio[i] == false)
                {
                    CartaOro.transform.position = AsedioController.position_asedio_fila[i].transform.position;
                    AsedioController.Cartas_Fila_Asedio.Add(CartaOro.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaOro.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Asedio[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }
    }

 public void Invocar_SilverCard(Silver_Card CartaPlata)
    {
        if(CartaPlata.Posicion_Fila == "Cuerpo a Cuerpo")
        {
            for(int i = 0; i < posicionesOcupadas_Ataque.Length; i++)
            {
                if(posicionesOcupadas_Ataque[i] == false)
                {
                    CartaPlata.transform.position = AttackController.position_ataque_fila[i].transform.position;
                    AttackController.Cartas_Fila_Ataque.Add(CartaPlata.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaPlata.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Ataque[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

        else if(CartaPlata.Posicion_Fila == "Distancia")
        {
             for(int i = 0; i < posicionesOcupadas_Distancia.Length; i++)
            {
                if(posicionesOcupadas_Distancia[i] == false)
                {
                    CartaPlata.transform.position = DistanciaController.position_distancia_fila[i].transform.position;
                    DistanciaController.Cartas_Fila_Distancia.Add(CartaPlata.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaPlata.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Distancia[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

         else if(CartaPlata.Posicion_Fila == "Asedio")
        {
             for(int i = 0; i < posicionesOcupadas_Asedio.Length; i++)
            {
                if(posicionesOcupadas_Asedio[i] == false)
                {
                    CartaPlata.transform.position = AsedioController.position_asedio_fila[i].transform.position;
                    AsedioController.Cartas_Fila_Asedio.Add(CartaPlata.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaPlata.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Asedio[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

    }



    // Invocar cartas clima 

    public void Invocar_Weather_Card(Weather_Card CartaClima)
    {
        if(CartaClima.Posicion_Fila == "Clima Zona")
        {
            for(int i = 0; i < posicionesOcupadas_Clima.Length; i++)
            {
                if(posicionesOcupadas_Clima[i] == false)
                {
                    CartaClima.transform.position = ClimaController.position_clima_fila[i].transform.position;
                    ClimaController.Cartas_Fila_Clima.Add(CartaClima.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaClima.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Clima[i]= true;
                   // ACtualiza_Marcador();
                    break;
                }
                else if( i == 2 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

    }



      public void Invocar_Aumento_Card(Aumento_Card CartaAumento)
    {
        if(CartaAumento.Posicion_Fila == "Aumento Zone")
        {
            for(int i = 0; i < posicionesOcupadas_Aumento.Length; i++)
            {
                if(posicionesOcupadas_Aumento[i] == false)
                {
                    CartaAumento.transform.position = AumentoController.position_aumento_fila[i].transform.position;
                    AumentoController.Cartas_Fila_Aumento.Add(CartaAumento.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaAumento.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Aumento[i]= true;
                   // ACtualiza_Marcador();
                    break;
                }
                else if( i == 3 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

    }

    
 public void Invocar_DespejeCard(Despeje_Card CartaDespeje)
    {
        if(CartaDespeje.Posicion_Fila == "Cuerpo a Cuerpo")
        {
            for(int i = 0; i < posicionesOcupadas_Ataque.Length; i++)
            {
                if(posicionesOcupadas_Despeje[i] == false)
                {
                    CartaDespeje.transform.position = AttackController.position_ataque_fila[i].transform.position;
                    AttackController.Cartas_Fila_Ataque.Add(CartaDespeje.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaDespeje.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Ataque[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

        else if(CartaDespeje.Posicion_Fila == "Distancia")
        {
             for(int i = 0; i < posicionesOcupadas_Distancia.Length; i++)
            {
                if(posicionesOcupadas_Despeje[i] == false)
                {
                    CartaDespeje.transform.position = DistanciaController.position_distancia_fila[i].transform.position;
                    DistanciaController.Cartas_Fila_Distancia.Add(CartaDespeje.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaDespeje.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Distancia[i]= true;
                    ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

         else if(CartaDespeje.Posicion_Fila == "Asedio")
        {
             for(int i = 0; i < posicionesOcupadas_Asedio.Length; i++)
            {
                if(posicionesOcupadas_Asedio[i] == false)
                {
                    CartaDespeje.transform.position = AsedioController.position_asedio_fila[i].transform.position;
                    AsedioController.Cartas_Fila_Asedio.Add(CartaDespeje.gameObject);
                    int index = Cards_In_Hand.IndexOf(CartaDespeje.gameObject);
                    Cards_In_Hand.RemoveAt(index);
                    Cards_In_Hand.Insert(index, null);
                    Mazo.listaBooleana.RemoveAt(index);
                    Mazo.listaBooleana.Insert(index, false);
                    posicionesOcupadas_Asedio[i]= true;
                   // ACtualiza_Marcador();
                    break;
                }
                else if( i == 4 )
                {
                    Debug.Log("No se puede convocar");
                }
            }
        }

    }












     // Agrega este namespace para usar la función Sum()


    // Otros miembros de la clase...

    // Método para calcular la suma de los puntos de ataque de las cartas en la fila "Cuerpo a Cuerpo"
  public int Cuerpo_A_Cuerpo_Puntos()
{
    int sumaAtaque = 0;

    // Recorre las cartas en la fila "Cuerpo a Cuerpo" y suma sus puntos de ataque
    foreach (var carta in AttackController.Cartas_Fila_Ataque)
    {
        // Verifica que la carta no sea nula
        if (carta != null)
        {
            // Intenta obtener el componente Golden_Card de la carta
            Golden_Card cartaOro = carta.GetComponent<Golden_Card>();
            // Si es una carta Golden_Card, suma sus puntos de ataque
            if (cartaOro != null)
            {
                sumaAtaque += cartaOro.Atk;
            }
            // Si no es una carta Golden_Card, intenta obtener el componente Silver_Card
            else
            {
                Silver_Card cartaPlata = carta.GetComponent<Silver_Card>();
                // Si es una carta Silver_Card, suma sus puntos de ataque
                if (cartaPlata != null)
                {
                    sumaAtaque += cartaPlata.Atk;
                }
            }
        }
    }

    return sumaAtaque;
}

 public int Distancia_Puntos()
{
    int sumaAtaque = 0;

    // Recorre las cartas en la fila "Distancia" y suma sus puntos de ataque
    foreach (var carta in DistanciaController.Cartas_Fila_Distancia)
    {
        // Verifica que la carta no sea nula
        if (carta != null)
        {
            // Intenta obtener el componente Golden_Card de la carta
            Golden_Card cartaOro = carta.GetComponent<Golden_Card>();
            // Si es una carta Golden_Card, suma sus puntos de ataque
            if (cartaOro != null)
            {
                sumaAtaque += cartaOro.Atk;
            }
            // Si no es una carta Golden_Card, intenta obtener el componente Silver_Card
            else
            {
                Silver_Card cartaPlata = carta.GetComponent<Silver_Card>();
                // Si es una carta Silver_Card, suma sus puntos de ataque
                if (cartaPlata != null)
                {
                    sumaAtaque += cartaPlata.Atk;
                }
            }
        }
    }

    return sumaAtaque;
}

 public int Asedio_Puntos()
{
    int sumaAtaque = 0;

    // Recorre las cartas en la fila "Cuerpo a Cuerpo" y suma sus puntos de ataque
    foreach (var carta in AsedioController.Cartas_Fila_Asedio)
    {
        // Verifica que la carta no sea nula
        if (carta != null)
        {
            // Intenta obtener el componente Golden_Card de la carta
            Golden_Card cartaOro = carta.GetComponent<Golden_Card>();
            // Si es una carta Golden_Card, suma sus puntos de ataque
            if (cartaOro != null)
            {
                sumaAtaque += cartaOro.Atk;
            }
            // Si no es una carta Golden_Card, intenta obtener el componente Silver_Card
            else
            {
                Silver_Card cartaPlata = carta.GetComponent<Silver_Card>();
                // Si es una carta Silver_Card, suma sus puntos de ataque
                if (cartaPlata != null)
                {
                    sumaAtaque += cartaPlata.Atk;
                }
            }
        }
    }

    return sumaAtaque;
}




     public int ActualizarTextoSumaAtaque()
    {
        int puntos_Cuerpo_a_Cuerpo = Cuerpo_A_Cuerpo_Puntos();
        int puntos_Distancia = Distancia_Puntos();
        int puntos_Asedio = Asedio_Puntos();

        return puntos_Cuerpo_a_Cuerpo + puntos_Distancia + puntos_Asedio;
    }

     public void ACtualiza_Marcador()
    {
        int totalpoints = ActualizarTextoSumaAtaque();
        Marcador.text = totalpoints.ToString();
    }

    // Otros métodos de la clase...

    // Método Invocar_GoldCard y otros métodos...
}



    
 



























