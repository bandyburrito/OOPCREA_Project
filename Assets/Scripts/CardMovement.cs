using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using static GameManager;

public class CardMovement : MonoBehaviour, IPointerClickHandler
{
    public float moveUpAmount = 3f;

    private bool isMovedUp = false;

    public TextMeshProUGUI EnergyText;
    private int energy = 5;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isMovedUp)
        {

            if (GetComponent<Card_UI>().cardData.GetCardCost() <= energy)
            {
                transform.Translate(0, moveUpAmount, 0);
                isMovedUp = true;
                energy -= GetComponent<Card_UI>().cardData.GetCardCost();
                EnergyText.text = energy.ToString();
            }
            else
            {
                Debug.Log("Not enough energy to play this card!");
            }

            


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

    

    
} 