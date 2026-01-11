using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public enum CardType // setting a simpler form of REFERENCING THEM instead of string!
{
    Attack,
    Defense,
    Both
}

public class CardClass {

    private string cardName;
    private int energyCost;
    private string description;
    private CardType cardType;
    private int attackValue;
    private int defenseValue;
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI cardCostText;
    public TextMeshProUGUI cardDescriptionText;
    public GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // in some references of the script we werent able to reference the gamemanager so we added this TO get some stuff it wasnt able to prior to this
    }

    public CardClass(string name, int cost, string desc, CardType type, int attack = 0, int defense = 0) // KONSTRUKTORI I KLASSES
    {
        this.cardName = name;
        this.energyCost = cost;
        this.description = desc;
        this.cardType = type;
        this.attackValue = attack;
        this.defenseValue = defense;



        
    }

    public String GetCardName()
    {
        return cardName;
    }

    public int GetCardCost()
    {
        return energyCost;
    }

    public String GetCardDescription()
    {
        return description;
    }


    public CardType GetCardType()
    {
        return cardType;
    }

    public int GetAttackValue()
    {
        return attackValue;
    }   


    public int GetDefenseValue()
    {
        return defenseValue;
    }


    public void CardDetails(int index)
    {
        
        Card_UI[] cardUIs = GameObject.FindObjectsOfType<Card_UI>();  // kur thirret funksioni e gjen skripten CARD UI
        cardUIs[index].Init(this, index);
        // E SHTIN FUNKSIONIN NE CARD UI ME INIZIALIZU YAYYYYYYY throug "THIS" qe esht OBJEKTI SPECIFIK 
    }

    
}


