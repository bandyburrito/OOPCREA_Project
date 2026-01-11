using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class EnemyTurn : MonoBehaviour
{

    public EnemyBehaviour enemyBehaviour;
    public int enemyHealth = 100;
    public Image enemyHealthBar;

    


    public void DealDamage(int damage)
    {

        if (enemyBehaviour.GettotalEnemyShield() > 0)
        {
            int shield = enemyBehaviour.GettotalEnemyShield();
            if (damage <= shield)
            {
                enemyBehaviour.SettotalEnemyShield(enemyBehaviour.GettotalEnemyShield() - damage);
                damage = 0;
            }
            else
            {
                damage -= shield;
                enemyBehaviour.SettotalEnemyShield(0);
            }
            enemyBehaviour.EnemyShieldAmount.text = enemyBehaviour.GettotalEnemyShield().ToString();
        }

        enemyHealth -= damage;
        UpdateHealthBar();
        CheckEnemyDefeat();


    }

    private void UpdateHealthBar()
    {
        float healthPercentage = (float)enemyHealth / 100f;
        enemyHealthBar.fillAmount = healthPercentage;
    }

    public void CheckEnemyDefeat()
    {
        if (enemyHealth <= 0)
        {
            Debug.Log("enemy died");
            SceneManager.LoadSceneAsync(1);
        }
    }   




}
