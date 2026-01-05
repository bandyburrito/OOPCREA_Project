using System.Collections.Generic;
using UnityEngine;

public class MageDeck : MonoBehaviour 
{
   public static List<CardClass> magedeck = new List<CardClass>()
{
new CardClass("Fireball", 3, "Deal 7 damage to target enemy."),
new CardClass("Frost Nova", 2, "Freeze all enemies for 1 turn."),
new CardClass("Arcane Missiles", 2, "Fire 5 missiles that deal 1 damage each randomly."),
new CardClass("Mana Shield", 2, "Lose 2 energy but gain 10 block."),
new CardClass("Lightning Bolt", 4, "Deal 10 damage to a single target."),
new CardClass("Blizzard", 5, "Deal 3 damage to all enemies and freeze them for 1 turn."),
new CardClass("Arcane Intellect", 2, "Draw 3 cards."),
new CardClass("Ice Block", 4, "Prevent your next fatal damage and become immune for 1 turn."),
new CardClass("Pyroblast", 5, "Deal 15 damage to target enemy."),
new CardClass("Polymorph", 3, "Transform target enemy into a sheep for 2 turns."),
new CardClass("Flamestrike", 4, "Deal 6 damage to all enemies."),
new CardClass("Counterspell", 3, "Negate the next enemy ability."),
new CardClass("Arcane Explosion", 2, "Deal 4 damage to all enemies."),
new CardClass("Mirror Image", 2, "Summon 2 illusions with 3 health each."),
new CardClass("Time Warp", 5, "Take an extra turn immediately."),
new CardClass("Frostbolt", 2, "Deal 5 damage and freeze target for 1 turn."),
new CardClass("Spell Power", 1, "Your next spell deals double damage."),
new CardClass("Teleport", 2, "Return all enemies to their starting position."),
new CardClass("Meteor", 5, "Deal 8 damage to target and 3 damage to adjacent enemies."),
new CardClass("Evocation", 3, "Restore 3 energy immediately."),
new CardClass("Cone of Cold", 3, "Deal 4 damage to all enemies in front and freeze them."),
new CardClass("Mana Burn", 2, "Target enemy loses 2 energy."),
new CardClass("Arcane Barrage", 3, "Deal 2 damage for each card in your hand."),
new CardClass("Ring of Frost", 4, "Create a zone that freezes enemies for 2 turns."),
new CardClass("Combustion", 4, "Your next 3 spells are guaranteed critical hits."),
new CardClass("Spellsteal", 3, "Copy the last ability used by an enemy."),
new CardClass("Slow", 2, "Reduce enemy speed by 50% for 3 turns."),
new CardClass("Living Bomb", 3, "Deal 4 damage now and 6 damage after 2 turns."),
new CardClass("Presence of Mind", 1, "Your next spell costs 0 energy."),
new CardClass("Dragon's Breath", 4, "Deal 8 damage in a cone to multiple enemies.")
    };
    
}
