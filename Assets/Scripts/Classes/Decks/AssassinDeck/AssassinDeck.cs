using System.Collections.Generic;
using UnityEngine;

public class AssassinDeck : MonoBehaviour 
{
    public static List<CardClass> assassindeck = new List<CardClass>()
    {
        new CardClass("Backstab", 2, "Deal 5 damage. If the target is stunned, deal 10 damage instead.", CardType.Attack, 5, 0),
        new CardClass("Poison Dagger", 3, "Apply poison to the target, dealing 3 damage over 3 turns.", CardType.Attack, 3, 0),
        new CardClass("Shadowstep", 1, "Teleport behind the target and gain stealth for 1 turn.", CardType.Defense, 0, 0),
        new CardClass("Evasion", 2, "Increase your dodge chance by 20% for 2 turns.", CardType.Defense, 0, 0),
        new CardClass("Assassinate", 5, "Instantly kill a stunned target.", CardType.Attack, 30, 0),      
        new CardClass("Smoke Bomb", 3, "Create a smoke screen that grants stealth to all allies for 2 turns.", CardType.Defense, 0, 0),
        new CardClass("Blade Flurry", 2, "Attack all enemies for 4 damage.", CardType.Attack, 4, 0),
        new CardClass("Cloak of Shadows", 2, "Become invisible for 1 turn.", CardType.Defense, 0, 0),
        new CardClass("Fan of Knives", 3, "Throw knives at all enemies, dealing 2 damage each.", CardType.Attack, 2, 0),
        new CardClass("Garrote", 2, "Silence the target and deal 4 damage over 2 turns.", CardType.Attack, 4, 0),
        new CardClass("Quick Strike", 1, "Deal 3 damage instantly.", CardType.Attack, 3, 0),
        new CardClass("Vanish", 3, "Remove yourself from combat for 1 turn and draw 2 cards.", CardType.Defense, 0, 0),
        new CardClass("Sap", 2, "Stun the target for 1 turn.", CardType.Defense, 0, 0),
        new CardClass("Ambush", 2, "Deal 8 damage if you are in stealth.", CardType.Attack, 8, 0),
        new CardClass("Preparation", 1, "Your next card costs 2 less energy.", CardType.Defense, 0, 0),
        new CardClass("Sprint", 2, "Draw 4 cards.", CardType.Defense, 0, 0),
        new CardClass("Kidney Shot", 3, "Deal 4 damage and stun the target for 1 turn.", CardType.Attack, 4, 0),
        new CardClass("Cheap Shot", 2, "Deal 3 damage and interrupt enemy action.", CardType.Attack, 3, 0),
        new CardClass("Gouge", 2, "Deal 3 damage and apply bleed for 2 turns.", CardType.Attack, 3, 0),
        new CardClass("Shiv", 1, "Deal 2 damage and draw 1 card.", CardType.Attack, 2, 0),
        new CardClass("Deadly Poison", 2, "Your next 3 attacks apply poison.", CardType.Defense, 0, 0),
        new CardClass("Cold Blood", 2, "Your next attack deals double damage.", CardType.Defense, 0, 0),
        new CardClass("Adrenaline Rush", 3, "Gain 2 energy immediately.", CardType.Defense, 0, 0),
        new CardClass("Feint", 1, "Reduce incoming damage by 50% this turn.", CardType.Defense, 0, 3),
        new CardClass("Shadow Dance", 2, "Enter stealth and your abilities cost 1 less for 2 turns.", CardType.Defense, 0, 0),
        new CardClass("Crimson Vial", 2, "Restore 5 health.", CardType.Defense, 0, 0),
        new CardClass("Marked for Death", 3, "Target takes 50% more damage from all sources for 2 turns.", CardType.Defense, 0, 0),
        new CardClass("Riposte", 3, "Block the next attack and counter for equal damage.", CardType.Defense, 0, 5),
        new CardClass("Distract", 1, "Target enemy skips their next turn.", CardType.Defense, 0, 0),
        new CardClass("Execute", 2, "Deal massive damage to enemies below 30% health.", CardType.Attack, 15, 0),
        new CardClass("Distract", 1, "Target enemy skips their next turn.", CardType.Defense, 0, 0),
        new CardClass("Execute", 2, "Deal massive damage to enemies below 30% health.", CardType.Attack, 15, 0)
    };
}
