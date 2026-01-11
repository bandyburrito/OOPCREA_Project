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
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{


    public EnemyBehaviour enemyBehaviour;
    public Button Knight;
    public Button Assassin;
    public Button Mage;
    public TextMeshProUGUI DiscardPileText;
    public TextMeshProUGUI DrawPileText;
    public TextMeshProUGUI EnergyText;
    public TextMeshProUGUI shieldAmountText;
    public int shieldAmount = 0;
    private int discardPileCount = 0;
    private int drawPileCount = 56;
    private int currentEnergy = 5;
    public GameObject CARDHANDs;
    public List<CardClass> Deck ;// ni public list ME CARDS(gabimisht named CardClass) qe e ka emrin Deck
    public List<CardClass> Hand = new List<CardClass>();   // cards in hand
    public GameObject PanelClassCanvas;
    public EnemyTurn enemyTurn;
    private string deckPicked; // to store which deck was picked
    



    void Start()
    {
      PanelClassCanvas.SetActive(true); // canvasi per class select me u shfaq ne start
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
        deckPicked = "Knight";
        // Buton 1 ne Class select per the Knight class
        Deck = GetCurrentDeck("Knight"); // using getters to change the decks based on class selection
        Debug.Log("Knight Deck Selected"); // only for debugging purposes
        PanelClassCanvas.SetActive(false); // me e nal the selector canvas
        Draw();
        
    }

    public void Button2()
    {
        deckPicked = "Assassin";
        // Buton 2 ne Class select per the Assassin class
        Deck = GetCurrentDeck("Assassin");
        Debug.Log("Assassin Deck Selected");
        PanelClassCanvas.SetActive(false);
        Draw();
    }

    public void Button3()
    {
        deckPicked = "Mage";
        // Buton 3 ne Class select per the Mage class
        Deck = GetCurrentDeck("Mage"); 
        Debug.Log("Mage Deck Selected");
        PanelClassCanvas.SetActive(false);
        Draw();
        
      
    }

    public void EndTurn()// funksioni me end the turn.
    {

        
        Hand.Clear(); // e merr listen e cards qe jan ne dor edhe i bon clear 
        Draw(); // e thirr funksionin draw per me i bo draw 4 cards te reja
        discardPileCount += 4; //e ndrron ten e discard pile tu i shtu edhe 4 cards
        DiscardPileText.text = discardPileCount.ToString(); // update i UI

        drawPileCount -= 4; // kur bon draw 4 cards me e zvoglon draw pile count me 4
        DrawPileText.text = drawPileCount.ToString(); // edhe kjo me update UI

        enemyBehaviour.EnemyPolymorph();
        enemyBehaviour.ShowTextEarlier();

      
        for (int i = 0; i < 4; i++) // e kena shti 4 here me check IT WORKED!
        {
            CardMovement[] cardMovements = GameObject.FindObjectsOfType<CardMovement>();
            cardMovements[i].MoveCardDown();
            ResetEnergy();
        }


        if (drawPileCount <= 0) // nese draw pile count osht 0 ose me pak
        {
            drawPileCount = 56; // e reset draw pile count
            DrawPileText.text = drawPileCount.ToString(); // update UI
            discardPileCount = 0; // e reset discard pile count
            DiscardPileText.text = discardPileCount.ToString(); // update UI

            Deck = GetCurrentDeck(deckPicked); // me i rishuffle deckat
            Debug.Log(Deck.Count.ToString());
        }
    }



    public List<CardClass> Draw()
    {
        for (int i = 0; i < 4; i++) // shkon derin vleren 4 per me bo draw 4 cards
        {
            Hand.Add(Deck[0]); // 
            Deck.RemoveAt(0);
            Debug.Log(Hand[i].GetCardName());
            Hand[i].CardDetails(i); // per the card qe bohet DRAW me e qit ne CARD DETAILS
            
        }     
        return Hand;
    }

    public int GetCurrentEnergy()
    {
        return currentEnergy;
    }

    public void SpendEnergy(int amount)
    {
        currentEnergy -= amount;
        EnergyText.text = currentEnergy.ToString();
    }

    public void ResetEnergy()
    {
        currentEnergy = 5;
        EnergyText.text = currentEnergy.ToString();
    }

    public void ShieldingDone(int shieldBonus)
    {
        shieldAmount += shieldBonus;
        shieldAmountText.text = shieldAmount.ToString();
    } 

  

    


    
}


      

