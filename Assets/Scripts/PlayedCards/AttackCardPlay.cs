using UnityEngine;

public class AttackCardPlay : CardPlay
{
    private int attackvalue;
    

    public AttackCardPlay(int attack) // constructor 
    {
        gameManager = FindObjectOfType<GameManager>();

        attackvalue = attack;
    }
    public override void Play()
    {
        gameManager.enemyTurn.DealDamage(attackvalue);
    }


}
