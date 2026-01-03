using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 
using UnityEngine.UI; 
using UnityEditor;
using static AssassinDeck;
using static KnightDeck;    
using static MageDeck;
public class GameManager : MonoBehaviour
{

    public Button Knight;
    public Button Assassin;
    public Button Mage;

    public List<CardClass> Deck ;

    public GameObject PanelClassCanvas;
    void Start()
    {
      PanelClassCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public List<CardClass> GetCurrentDeck(String ClassName)
    {
        if (ClassName == "Assassin")
        {
            Deck = AssassinDeck.assassindeck;
            for (int i = 0; i < Deck.Count; i++)
            {
                int randomIndex = Random.Range(0, Deck.Count); //get a random position per card
                CardClass temp = Deck[i]; // e run the first card te non shuffled deck
                Deck[i] = Deck[randomIndex]; // e qet te e para the card with random position
                Deck[randomIndex] = temp; // 
            }
            return Deck;
        }
        if (ClassName == "Knight")
        {
            Deck = KnightDeck.knightdeck;
            for (int i = 0; i < Deck.Count; i++)
            {
                int randomIndex = Random.Range(0, Deck.Count); //get a random position per card
                CardClass temp = Deck[i]; // e run the first card te non shuffled deck
                Deck[i] = Deck[randomIndex]; // e qet te e para the card with random position
                Deck[randomIndex] = temp; // 
            }
            return Deck;
        }
        if (ClassName == "Mage")
        {
            Deck = MageDeck.magedeck;
            for (int i = 0; i < Deck.Count; i++)
            {
                int randomIndex = Random.Range(0, Deck.Count); //get a random position per card
                CardClass temp = Deck[i]; // e run the first card te non shuffled deck
                Deck[i] = Deck[randomIndex]; // e qet te e para the card with random position
                Deck[randomIndex] = temp; // 
            }
            return Deck;
        }
        return null;

        
    }

    public void Button1()
    {
        Deck = GetCurrentDeck("Knight");
        Debug.Log("Knight Deck Selected");
        Destroy(PanelClassCanvas);
    }

    public void Button2()
    {
        Deck = GetCurrentDeck("Assassin");
        Debug.Log("Assassin Deck Selected");
        Destroy(PanelClassCanvas);
    }

    public void Button3()
    {
        Deck = GetCurrentDeck("Mage");
        Debug.Log("Mage Deck Selected");
        Destroy(PanelClassCanvas);
    }


}
       

