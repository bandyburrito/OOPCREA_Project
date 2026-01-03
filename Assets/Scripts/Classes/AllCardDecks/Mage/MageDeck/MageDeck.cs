using System.Collections.Generic;
using UnityEngine;

public class MageDeck : MonoBehaviour 
{
   public static List<CardClass> magedeck = new List<CardClass>()
    {
        new CardClass("Fireball", 3, "Deal 5 damage to a target."),
        new CardClass("Frost Nova", 4, "Deal 3 damage to all enemies and apply frostbite."),
        new CardClass("Arcane Blast", 2, "Deal 4 damage to a target and reduce their magic resistance by 1."),
        new CardClass("Mana Shield", 1, "Gain 3 magic resistance for the next turn."),
        new CardClass("Blizzard", 5, "Deal 2 damage to all enemies and apply frostbite."),
        new CardClass("Assassinate", 5, "Instantly kill a stunned target."),
    };
    
}
