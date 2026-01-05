using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CardClass 
{


    public String CardName;
    private int CardCost;
    private String CardDescripton;
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI cardCostText;
    public TextMeshProUGUI cardDescriptionText;

    
    public GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public CardClass(String name, int cost, String description) // KONSTRUKTORI 
    {
        this.CardName = name;
        this.CardCost = cost;
        this.CardDescripton = description;
    }

    public String GetCardName()
    {
        return CardName;
    }

    public int GetCardCost()
    {
        return CardCost;
    }

    public String GetCardDescription()
    {
        return CardDescripton;
    }
    public void CardDetails(int index)
    {
        
        Card_UI[] cardUIs = GameObject.FindObjectsOfType<Card_UI>(); 
    // kur thirret funksioni e gjen skripten CARD UI
        cardUIs[index].Init(this);
        // E SHTIN FUNKSIONIN NE CARD UI ME INIZIALIZU YAYYYYYYY throug "THIS" qe esht OBJEKTI SPECIFIK 
    }

}


