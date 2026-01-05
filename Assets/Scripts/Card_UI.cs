using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Card_UI : MonoBehaviour
{
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI cardCostText;
    public TextMeshProUGUI cardDescriptionText;
    public CardClass cardData;

    public void Init(CardClass data) 
    {
        cardData = data; // me recheck which card e ka thirr qajo 
        UpdateUI(); // thirret funksioni 
    }

    void UpdateUI()
    {
        cardNameText.text = cardData.GetCardName();
        cardCostText.text = cardData.GetCardCost().ToString();
        cardDescriptionText.text = cardData.GetCardDescription();
    }
}


