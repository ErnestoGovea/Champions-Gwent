/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
   public DECKS jugador_Deck;
   public DECKS rival_Deck;
   public GameObject PrefabLeaderCard;
   public GameObject MyLeaderZone;
   public GameObject RivalLeaderZone;
   public MANOS jugador;
   public MANOS jugador_Rival;
   public Ataque MyMeleeZone;
   public Ataque RivalMeleeZone;
   public Distancia MyFromDistanceZone;
   public Distancia RivalFromDistanceZone;
   public Asedio MySiegeZone;
   public Asedio RivalSiegeZone;
   //public Cementerio MyGraveyard;
   //public Cementerio RivalGraveyard;
   public int puntos;
   public int puntos_Rivales;
   void Start()
   {
    Debug.Log("Ronda 1");
    
      jugador_Deck.ShuffleDeck();
      rival_Deck.ShuffleDeck();
      jugador.Turno = true;
       Debug.Log("Es el turno del jugador 1");
   }
   void Update()
   {
    puntos = jugador.ActualizarTextoSumaAtaque();
    puntos_Rivales = jugador_Rival.ActualizarTextoSumaAtaque();
    if(MANOS.ronda == 1)
    {
      if(jugador.paso_Ronda && jugador_Rival.paso_Ronda)
      {
         Ganador_Ronda();
        //jugador.CleanBoard();
      }
    }
    else if(MANOS.ronda == 2)
    {
      
    }
   }
   public void MyChangeTurn()
    {
      if(jugador.cartas_Jugadas != 0 && !jugador_Rival.paso_Ronda)
      {
        jugador.Turno = false;
        jugador_Rival.Turno = true;
        jugador_Rival.cartas_Jugadas = 0;
        Debug.Log("Es el turno del jugador 2");
      }
      else if(jugador_Rival.paso_Ronda)
      {
        Debug.Log("No puede pasar turno, ya el jugador contrario termino su ronda");
      }
      else
      {
        Debug.Log("Debe jugar al menos una carta");
      }
    }
    
    public void RivalChangeTurn()
    {
      if(jugador_Rival.cartas_Jugadas != 0 && !jugador.paso_Ronda)
      {
       jugador.Turno= true;
       jugador_Rival.Turno= false;
       jugador.cartas_Jugadas = 0;
       Debug.Log("Es el turno del jugador 1");
      }
      else if(jugador.paso_Ronda)
      {
        Debug.Log("No puede pasar el turno ,ya el jugador contrario termino su ronda");
      }
      else
      {
        Debug.Log("Debe jugar al menos una carta");
      }
    }
    public void MyPassRound()
    {
      if(jugador.cartas_Jugadas == 0 || jugador.Cards_In_Hand.Count==0 || jugador_Rival.Turno)
      {
        Debug.Log("Jugador 1 cedio su turno");
        jugador.paso_Ronda = true;
        jugador.Turno = false;
        jugador_Rival.Turno = true;
        jugador_Rival.cartas_Jugadas = 0;
      jugador_Rival.Posibilidad_de_Convocar = true;
      }
      else
      {
        Debug.Log("No puede pasar de ronda en este turno");
      }
    }
    public void RivalPassRound()
    {
      if(jugador_Rival.cartas_Jugadas == 0 || jugador_Rival.Cards_In_Hand.Count==0 || jugador.Turno)
      {
        Debug.Log("Jugador 2 cedio su turno");
        jugador_Rival.Turno = true;
        jugador.Turno = true;
        jugador_Rival.Turno = false;
        jugador.cartas_Jugadas = 0;
        jugador.Posibilidad_de_Convocar = true;
      }
      else
      {
        Debug.Log("No puede pasar de ronda en este turno");
      }
    }
    public void Ganador_Ronda()
    {
       Debug.Log("Se acabo la ronda");
       jugador.Turno = false;
        jugador_Rival.Turno = false;
        jugador.cartas_Jugadas = 0;
        jugador_Rival.cartas_Jugadas = 0;
        jugador.Posibilidad_de_Convocar = false;
        jugador_Rival.Posibilidad_de_Convocar = false;
        Debug.Log("Calculemos los puntos para ver al ganador");
        if(puntos>puntos_Rivales)
        {
          Debug.Log("La Ronda fue ganada por el Jugador 1");
          jugador.Rondas_GANADAS++;
          MANOS.ronda++;
        }
        else if(puntos<puntos_Rivales)
        {
          Debug.Log("La Ronda fue ganada por el Jugador 2");
          jugador_Rival.Rondas_GANADAS++;
          MANOS.ronda ++;
        }
        else if(puntos == puntos_Rivales)
        {
          Debug.Log("La Ronda termino en empate");
          MANOS.ronda ++;
        }
    }
    public void StartRound()
    {
       
    }
}*/
