using System.Collections.Generic;
using UnityEngine;

public class KnightDeck : MonoBehaviour 
{
   public static List<CardClass> knightdeck = new List<CardClass>()
    {new CardClass("Shield Bash", 2, "Deal 4 damage and gain 3 block."),
new CardClass("Defend", 1, "Gain 5 block."),
new CardClass("Heavy Strike", 3, "Deal 8 damage."),
new CardClass("Iron Wall", 2, "Gain 8 block for this turn."),
new CardClass("Taunt", 1, "Force all enemies to target you for 1 turn."),
new CardClass("Cleave", 3, "Deal 5 damage to all enemies."),
new CardClass("Battle Cry", 2, "All allies gain 3 strength for 2 turns."),
new CardClass("Last Stand", 4, "Gain block equal to your missing health."),
new CardClass("Retaliate", 2, "Deal 3 damage to attackers for 2 turns."),
new CardClass("Charge", 3, "Deal 7 damage and gain 2 block."),
new CardClass("Fortify", 2, "Gain 4 block that persists between turns."),
new CardClass("Heroic Strike", 4, "Deal 10 damage."),
new CardClass("Rally", 3, "Restore 6 health to all allies."),
new CardClass("Shield Wall", 4, "Gain 15 block but skip your next attack."),
new CardClass("Whirlwind", 5, "Deal damage equal to your block to all enemies."),
new CardClass("Second Wind", 2, "Restore 5 health and gain 3 block."),
new CardClass("Crushing Blow", 5, "Deal 12 damage and reduce target's armor by 5."),
new CardClass("Stalwart Defense", 3, "Gain 10 block. Block doesn't decay next turn."),
new CardClass("Sword and Board", 3, "Deal 5 damage and gain 5 block."),
new CardClass("Inspire", 2, "All allies deal 2 extra damage for 3 turns."),
new CardClass("Guardian's Oath", 4, "Take all damage for allies this turn and gain 8 block."),
new CardClass("Revenge", 3, "Deal damage equal to damage taken this turn."),
new CardClass("Armor Up", 1, "Gain 3 armor permanently."),
new CardClass("Bulwark", 2, "Gain block equal to your current armor."),
new CardClass("Shockwave", 4, "Deal 6 damage to all enemies and stun them for 1 turn."),
new CardClass("Indomitable", 5, "Become immune to damage for 1 turn."),
new CardClass("Power Strike", 3, "Deal 6 damage. Costs 1 less for each block you have."),
new CardClass("Steadfast", 1, "Gain 2 block and 1 strength."),
new CardClass("Bastion", 3, "Double your current block."),
new CardClass("Valiant Charge", 4, "Deal 9 damage and heal for half the damage dealt.")
    };
    
}

