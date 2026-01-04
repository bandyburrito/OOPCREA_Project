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
        new CardClass("Smoke Bomb", 3, "Create a smoke screen that grants stealth to all allies for 2 turns."),
        new CardClass("Blade Flurry", 4, "Attack all enemies for 4 damage."),
        new CardClass("Cloak of Shadows", 2, "Become invisible for 1 turn."),
        new CardClass("Fan of Knives", 3, "Throw knives at all enemies, dealing 2 damage each."),
        new CardClass("Garrote", 2, "Silence the target and deal 4 damage over 2 turns."), 
    };
    
}
