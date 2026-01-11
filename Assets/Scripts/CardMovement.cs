using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using static GameManager;
using UnityEngine.XR;
using System.CodeDom.Compiler;
using System.Linq.Expressions;

public class CardMovement : MonoBehaviour, IPointerClickHandler
{
    public float moveUpAmount = 3f;

    private bool isMovedUp = false;

    public GameManager gameManager;
    private int energyCost;
    private int cardIndex;
    private CardPlay cardPlayed;

   


    public void OnPointerClick(PointerEventData eventData)
    {
        energyCost = gameManager.Hand[cardIndex].GetCardCost();
        if (energyCost <= gameManager.GetCurrentEnergy())
        {
            gameManager.SpendEnergy(energyCost);
            transform.Translate(0, moveUpAmount, 0);
            isMovedUp = true;


            if (gameManager.Hand[cardIndex].GetCardType() == CardType.Attack)
            {
                cardPlayed = new AttackCardPlay(gameManager.Hand[cardIndex].GetAttackValue()); // HAD TO MAKE NEW CONSTRUCOR FOR THIS TO KNOW WTF CARD.PLAY IS :DDDDDDDDDDD
                cardPlayed.Play();
                Debug.Log("Played an Attack Card");
            }
            else if (gameManager.Hand[cardIndex].GetCardType() == CardType.Defense)
            {
               cardPlayed = new ShieldCardPlay(gameManager.Hand[cardIndex].GetDefenseValue());
                cardPlayed.Play();

                // the only difference without Polymorphism would be to call the shielding and attack functions directly from gamemanager
 }

         else if (gameManager.Hand[cardIndex].GetCardType() == CardType.Both)
            {
                cardPlayed = new AttackCardPlay(gameManager.Hand[cardIndex].GetAttackValue());
                cardPlayed.Play();

                cardPlayed = new ShieldCardPlay(gameManager.Hand[cardIndex].GetDefenseValue());
                cardPlayed.Play();
            }
        else
        {
            gameManager.EndTurn();
            gameManager.ResetEnergy();
            return;
        }
        
    }}

    public void MoveCardDown()
    {
        if (isMovedUp)
        {
            transform.Translate(0, -moveUpAmount, 0);
            isMovedUp = false;
        }
    }

    public void SetCardIndex(int index)
    {
        cardIndex = index;
    }

    
    

    
} 