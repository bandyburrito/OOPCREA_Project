using System.Collections.Generic;
using UnityEngine;

public class KnightDeck : MonoBehaviour 
{
   public static List<CardClass> knightdeck = new List<CardClass>()
    {
        new CardClass("Backstab", 2, "Deal 5 damage. If the target is stunned, deal 10 damage instead."),
        new CardClass("Poison Dagger", 3, "Apply poison to the target, dealing 3 damage over 3 turns."),
        new CardClass("Shadowstep", 1, "Teleport behind the target and gain stealth for 1 turn."),
        new CardClass("Evasion", 2, "Increase your dodge chance by 20% for 2 turns."),
        new CardClass("Assassinate", 5, "Instantly kill a stunned target."),       
    };
    
}
