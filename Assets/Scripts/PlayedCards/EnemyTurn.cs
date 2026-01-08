using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EnemyTurn : MonoBehaviour
{

    public int enemyHealth = 100;
    public Image enemyHealthBar;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DealDamage(int damage)
    {
        enemyHealth -= damage;
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        float healthPercentage = (float)enemyHealth / 100f;
        enemyHealthBar.fillAmount = healthPercentage;
    }
}
