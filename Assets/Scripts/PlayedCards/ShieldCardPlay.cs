using UnityEngine;

public class ShieldCardPlay : CardPlay
{
    
    private int shieldValue ;

    public ShieldCardPlay(int shield)
    {
        gameManager = FindObjectOfType<GameManager>();
        shieldValue = shield;
    }
   
    public override void Play()
    {
        gameManager.ShieldingDone(shieldValue);
    }


}