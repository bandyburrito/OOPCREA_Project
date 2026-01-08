using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using static GameManager;
using UnityEngine.XR;
using System.CodeDom.Compiler;

public class CardMovement : MonoBehaviour, IPointerClickHandler
{
    public float moveUpAmount = 3f;

    private bool isMovedUp = false;

    public GameManager gameManager;
    private int energyCost;
    private int cardIndex;

   


    public void OnPointerClick(PointerEventData eventData)
    {
        energyCost = gameManager.Hand[cardIndex].GetCardCost();
        if (energyCost <= gameManager.GetCurrentEnergy())
        {
            gameManager.SpendEnergy(energyCost);
            transform.Translate(0, moveUpAmount, 0);
            isMovedUp = true;
        }
        else
        {
            gameManager.EndTurn();
            gameManager.ResetEnergy();
            return;
        }
    }

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