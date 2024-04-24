using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DECKS : MonoBehaviour
{
    public MANOS Hand;
    public List<GameObject> deck = new List<GameObject>();
    public List<bool> listaBooleana = new List<bool>();
     void Start()
    {
        ShuffleDeck();

         for(int i = 0; i < 10; i++)
        {
            RobarCarta(Hand);
        }

    }
    public void ShuffleDeck()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            // Guarda la carta actual en una variable temporal
            GameObject temp = deck[i];
            // Genera un índice aleatorio entre el índice actual y el final del mazo
            int randomIndex = Random.Range(i, deck.Count);
            // Intercambia la carta actual con la carta en el índice aleatorio generado
            deck[i] = deck[randomIndex];
            // Coloca la carta guardada en la variable temporal en el lugar de la carta intercambiada
            deck[randomIndex] = temp;
        }
    }

    
   public void RobarCarta(MANOS Hand)
    {
        GameObject Copia_Carta = deck[0];
        deck.RemoveAt(0);

        for(int i = 0; i < listaBooleana.Count; i++)
        {
            if (listaBooleana[i] == false)
            {
                GameObject CARTA = Instantiate(Copia_Carta, Hand.ZONAS[i].transform.position,Quaternion.identity);
                CARTA.transform.SetParent(Hand.transform);
                Hand.Cards_In_Hand.Insert(i, CARTA);
                listaBooleana[i]=true;
                break;
            }

            if(i == 9)
            {
                Debug.Log("Basta ya pipo no saques mas cartas");

            }

        }
 
}
         



}
    
