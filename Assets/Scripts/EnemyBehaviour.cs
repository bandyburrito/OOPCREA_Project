using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class EnemyBehaviour : MonoBehaviour
{

    
    public TextMeshProUGUI EnemyAbility;
    public GameManager gameManager;
    
    private int enemyattack;
    private int enemyshield;
    private int polymorphTurnCount;
    public TextMeshProUGUI EnemyShieldAmount;
    private int totalEnemyShield;

    public Image playerHealthBar;
    private int playerHealth = 100;
    private int shieldValue;
    private int attackValue;


    public void Start()
    {
       ShowTextEarlier();
    }

    public void Update()
    {
        CheckPlayerDefeat();
    }   

    public int GettotalEnemyShield()
    {
        return totalEnemyShield;
    }
    public void SettotalEnemyShield(int value)
    {
        totalEnemyShield = value;
    }




    public void EnemyAction(int attack)
    {

        if (gameManager.shieldAmount > 0)
        {
            gameManager.shieldAmount -= attack;
            if (gameManager.shieldAmount < 0)
            {
                attack = -gameManager.shieldAmount;
                gameManager.shieldAmount = 0;
            }
            else
            {
                attack = 0;
            }
            gameManager.shieldAmountText.text = gameManager.shieldAmount.ToString();
   
        }
        else
        {
        enemyattack = attack;
        Debug.Log("Enemy attacks for: " + enemyattack);
        playerHealth -= (int)enemyattack;
        float healthPercentage = (float)playerHealth / 100f;
        playerHealthBar.fillAmount = healthPercentage;  

        }


    }

    public void EnemyAction(int amount, bool isShield)
    {
        enemyshield = amount;
        Debug.Log("Enemy shields for: " + amount);
        playerHealth -= (int)enemyattack;
        float healthPercentage = (float)playerHealth / 100f;
        playerHealthBar.fillAmount = healthPercentage;  
        totalEnemyShield += enemyshield;
        EnemyShieldAmount.text = totalEnemyShield.ToString();
    }


    public void EnemyAction(int amount1, int amount2)
    {
if (gameManager.shieldAmount > 0)
{
    gameManager.shieldAmount -= amount1;
    if (gameManager.shieldAmount < 0)
    {
        amount1 = -gameManager.shieldAmount;
        gameManager.shieldAmount = 0;
    }
    else
    {
        amount1 = 0;
    }
    gameManager.shieldAmountText.text = gameManager.shieldAmount.ToString();
}
        enemyattack = amount1;
        enemyshield = amount2;
        Debug.Log("Enemy attacks for: " + enemyattack + " and shields for: " + enemyshield);
        playerHealth -= (int)enemyattack;
        float healthPercentage = (float)playerHealth / 100f;
        playerHealthBar.fillAmount = healthPercentage;  
        totalEnemyShield += enemyshield;
        EnemyShieldAmount.text = totalEnemyShield.ToString();
    }

        public void EnemyUI(int value)
    {
        enemyattack = value;
        enemyshield = 0;
        EnemyAbility.text = "Enemy attacks for: " + enemyattack.ToString(); //turns the attack value into string to show it on UI
    }

    public void EnemyUI(int amount, bool isShield)
    {
        enemyshield = amount;
        enemyattack = 0;
        EnemyAbility.text = "Enemy shields for: " + amount.ToString(); // turns the shield value into string to show it on UI
    }


    public void EnemyUI(int amount1, int amount2)
    {
        enemyattack = amount1;
        enemyshield = amount2;
        EnemyAbility.text = "Enemy attacks for: " + enemyattack.ToString() + " and shields for: " + enemyshield.ToString();
    }

    public void ShowTextEarlier()
    {
        polymorphTurnCount = Random.Range(0, 3); // getting a random value
        switch (polymorphTurnCount)
        {
            case 0:
            attackValue = Random.Range(5, 15);
            EnemyUI(attackValue);
            break;
            
            case 1:
            shieldValue = Random.Range(3, 15);
            EnemyUI(shieldValue, true);   
            break;

            case 2:
            attackValue = Random.Range(5, 15);
            shieldValue = Random.Range(3, 15);  
            EnemyUI(attackValue, shieldValue);
            
            break;
        }
    }

    public void EnemyPolymorph()
    {
        switch (polymorphTurnCount)
        {
            case 0:
            EnemyAction(attackValue);
            break;
            
            case 1:
            EnemyAction(shieldValue, true);
            break;

            case 2:
            EnemyAction(attackValue, shieldValue);
            break;
        }

        ShowTextEarlier();
    }

    public void CheckPlayerDefeat()
    {
        if (playerHealth <= 0)
        {
            Debug.Log("player died");
            SceneManager.LoadSceneAsync(2);
        }
    }

}