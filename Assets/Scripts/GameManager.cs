using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; // for the shuffling algorithm
using UnityEngine.UI; 
using UnityEditor;
using TMPro;
using static AssassinDeck;
using static KnightDeck;    
using static MageDeck;

public class GameManager : MonoBehaviour
{

    public Button Knight;
    public Button Assassin;
    public Button Mage;



    public TextMeshProUGUI DiscardPileText;
    public TextMeshProUGUI DrawPileText;

    private int discardPileCount = 0;
    private int drawPileCount = 28;

    public GameObject CARDHANDs;

    public List<CardClass> Deck ;// ni public list ME CARDS(gabimisht named CardClass) qe e ka emrin Deck
    public List<CardClass> Hand = new List<CardClass>();   // cards in hand

    

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
                CardClass temp = Deck[i]; // takes the first card edhe e qet me ni temp placeholder
                Deck[i] = Deck[randomIndex]; // 
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
        Deck = GetCurrentDeck("Knight"); // using getters to change the decks based on class selection
        Debug.Log("Knight Deck Selected"); // only for debugging purposes
        PanelClassCanvas.SetActive(false); // me e nal the selector canvas
        Draw();
      
    }

    public void Button2()
    {
        Deck = GetCurrentDeck("Assassin");
        Debug.Log("Assassin Deck Selected");
        PanelClassCanvas.SetActive(false);
        Draw();
        
    }

    public void Button3()
    {
        Deck = GetCurrentDeck("Mage"); 
        Debug.Log("Mage Deck Selected");
        PanelClassCanvas.SetActive(false);
        Draw();
        
      
    }

    public void EndTurn()
    {
        Hand.Clear();
        Draw();
        discardPileCount += 4; 
        DiscardPileText.text = discardPileCount.ToString();

        drawPileCount -= 4; 
        DrawPileText.text = drawPileCount.ToString();

        

      

        
        for (int i = 0; i < 4; i++) // e kena shti 4 here me check IT WORKED!
        {
            CardMovement[] cardMovements = GameObject.FindObjectsOfType<CardMovement>();
            cardMovements[i].MoveCardDown();
        }

    }



    public List<CardClass> Draw()
    {
        for (int i = 0; i < 4; i++)
        {
            Hand.Add(Deck[0]); // 
            Deck.RemoveAt(0);
            Debug.Log(Hand[i].GetCardName());
            Hand[i].CardDetails(i); // per the card qe bohet DRAW me e qit ne CARD DETAILS
            
        }     
        return Hand;
    }

    


    
}
      

