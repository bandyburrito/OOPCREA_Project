using System;


public class CardClass 
{


    public String CardName;
    private int CardCost;
    private String CardDescripton;

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

}


