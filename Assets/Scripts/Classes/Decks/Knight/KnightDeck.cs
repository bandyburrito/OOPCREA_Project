using System.Collections.Generic;
using UnityEngine;

public class KnightDeck : MonoBehaviour 
{
    public static List<CardClass> knightdeck = new List<CardClass>()
    {
        new CardClass("Shield Bash", 2, "Deal 4 damage and gain 3 block.", CardType.Attack, 4, 3),
        new CardClass("Defend", 1, "Gain 5 block.", CardType.Defense, 0, 5),
        new CardClass("Heavy Strike", 3, "Deal 8 damage.", CardType.Attack, 8, 0),
        new CardClass("Iron Wall", 2, "Gain 8 block for this turn.", CardType.Defense, 0, 8),
        new CardClass("Taunt", 1, "Force all enemies to target you for 1 turn.", CardType.Defense, 0, 0),
        new CardClass("Cleave", 3, "Deal 5 damage to all enemies.", CardType.Attack, 5, 0),
        new CardClass("Battle Cry", 2, "All allies gain 3 strength for 2 turns.", CardType.Defense, 0, 0),
        new CardClass("Last Stand", 2, "Gain block equal to your missing health.", CardType.Defense, 0, 0),
        new CardClass("Retaliate", 2, "Deal 3 damage to attackers for 2 turns.", CardType.Defense, 3, 0),
        new CardClass("Charge", 3, "Deal 7 damage and gain 2 block.", CardType.Attack, 7, 2),
        new CardClass("Fortify", 2, "Gain 4 block that persists between turns.", CardType.Defense, 0, 4),
        new CardClass("Heroic Strike", 2, "Deal 10 damage.", CardType.Attack, 10, 0),
        new CardClass("Rally", 3, "Restore 6 health to all allies.", CardType.Defense, 0, 0),
        new CardClass("Shield Wall", 2, "Gain 15 block but skip your next attack.", CardType.Defense, 0, 15),
        new CardClass("Whirlwind", 3, "Deal damage equal to your block to all enemies.", CardType.Attack, 0, 0),
        new CardClass("Second Wind", 2, "Restore 5 health and gain 3 block.", CardType.Defense, 0, 3),
        new CardClass("Crushing Blow", 2, "Deal 12 damage and reduce target's armor by 5.", CardType.Attack, 12, 0),
        new CardClass("Stalwart Defense", 3, "Gain 10 block. Block doesn't decay next turn.", CardType.Defense, 0, 10),
        new CardClass("Sword and Board", 3, "Deal 5 damage and gain 5 block.", CardType.Attack, 5, 5),
        new CardClass("Inspire", 2, "All allies deal 2 extra damage for 3 turns.", CardType.Attack, 0, 0),
        new CardClass("Guardian's Oath", 2, "Take all damage for allies this turn and gain 8 block.", CardType.Defense, 0, 8),
        new CardClass("Revenge", 3, "Deal damage equal to damage taken this turn.", CardType.Attack, 0, 0),
        new CardClass("Armor Up", 1, "Gain 3 armor permanently.", CardType.Defense, 0, 3),
        new CardClass("Bulwark", 2, "Gain block equal to your current armor.", CardType.Defense, 0, 0),
        new CardClass("Shockwave", 2, "Deal 6 damage to all enemies and stun them for 1 turn.", CardType.Attack, 6, 0),
        new CardClass("Indomitable", 2, "Become immune to damage for 1 turn.", CardType.Defense, 0, 0),
        new CardClass("Power Strike", 3, "Deal 6 damage. Costs 1 less for each block you have.", CardType.Attack, 6, 0),
        new CardClass("Steadfast", 1, "Gain 2 block and 1 strength.", CardType.Defense, 0, 2),
        new CardClass("Bastion", 3, "Double your current block.", CardType.Defense, 0, 0),
        new CardClass("Valiant Charge", 2, "Deal 9 damage and heal for half the damage dealt.", CardType.Attack, 9, 0),
        new CardClass("Bastion", 3, "Double your current block.", CardType.Defense, 0, 0),
        new CardClass("Valiant Charge", 2, "Deal 9 damage and heal for half the damage dealt.", CardType.Attack, 9, 0)
    };
}
