using System.Collections.Generic;
using UnityEngine;

public class MageDeck : MonoBehaviour 
{
    public static List<CardClass> magedeck = new List<CardClass>()
    {
        new CardClass("Fireball", 2, "Deal 7 damage to target enemy.", CardType.Attack, 7, 0),
        new CardClass("Frost Nova", 2, "Freeze all enemies for 1 turn.", CardType.Defense, 0, 0),
        new CardClass("Arcane Missiles", 1, "Fire 5 missiles that deal 1 damage each randomly.", CardType.Attack, 5, 0),
        new CardClass("Mana Shield", 2, "Lose 2 energy but gain 10 block.", CardType.Defense, 0, 10),
        new CardClass("Lightning Bolt", 1, "Deal 10 damage to a single target.", CardType.Attack, 10, 0),
        new CardClass("Blizzard", 2, "Deal 3 damage to all enemies and freeze them for 1 turn.", CardType.Attack, 3, 0),
        new CardClass("Arcane Intellect", 1, "Draw 3 cards.", CardType.Defense, 0, 0),
        new CardClass("Ice Block", 2, "Prevent your next fatal damage and become immune for 1 turn.", CardType.Defense, 0, 0),
        new CardClass("Pyroblast", 1, "Deal 15 damage to target enemy.", CardType.Both, 15, 15),
        new CardClass("Polymorph", 1, "Transform target enemy into a sheep for 2 turns.", CardType.Defense, 0, 0),
        new CardClass("Flamestrike", 2, "Deal 6 damage to all enemies.", CardType.Attack, 6, 0),
        new CardClass("Counterspell", 1, "Negate the next enemy ability.", CardType.Defense, 0, 0),
        new CardClass("Arcane Explosion", 2, "Deal 4 damage to all enemies.", CardType.Attack, 4, 0),
        new CardClass("Mirror Image", 2, "Summon 2 illusions with 3 health each.", CardType.Defense, 0, 3),
        new CardClass("Time Warp", 1, "Take an extra turn immediately.", CardType.Defense, 0, 0),
        new CardClass("Frostbolt", 1, "Deal 5 damage and freeze target for 1 turn.", CardType.Attack, 5, 0),
        new CardClass("Spell Power", 1, "Your next spell deals double damage.", CardType.Defense, 0, 0),
        new CardClass("Teleport", 2, "Return all enemies to their starting position.", CardType.Defense, 0, 0),
        new CardClass("Meteor", 2, "Deal 8 damage to target and 3 damage to adjacent enemies.", CardType.Attack, 8, 0),
        new CardClass("Evocation", 2, "Restore 3 energy immediately.", CardType.Defense, 0, 0),
        new CardClass("Cone of Cold", 2, "Deal 4 damage to all enemies in front and freeze them.", CardType.Attack, 4, 0),
        new CardClass("Mana Burn", 1, "Target enemy loses 2 energy.", CardType.Defense, 0, 0),
        new CardClass("Arcane Barrage", 1, "Deal 2 damage for each card in your hand.", CardType.Attack, 2, 0),
        new CardClass("Ring of Frost", 2, "Create a zone that freezes enemies for 2 turns.", CardType.Defense, 0, 0),
        new CardClass("Combustion", 2, "Your next 3 spells are guaranteed critical hits.", CardType.Defense, 0, 0),
        new CardClass("Spellsteal", 1, "Copy the last ability used by an enemy.", CardType.Defense, 0, 0),
        new CardClass("Slow", 2, "Reduce enemy speed by 50% for 3 turns.", CardType.Defense, 0, 0),
        new CardClass("Living Bomb", 1, "Deal 4 damage now and 6 damage after 2 turns.", CardType.Attack, 4, 0),
        new CardClass("Presence of Mind", 1, "Your next spell costs 0 energy.", CardType.Defense, 0, 0),
        new CardClass("Dragon's Breath", 2, "Deal 8 damage in a cone to multiple enemies.", CardType.Attack, 8, 0),
        new CardClass("Presence of Mind", 1, "Your next spell costs 0 energy.", CardType.Defense, 0, 0),
        new CardClass("Dragon's Breath", 2, "Deal 8 damage in a cone to multiple enemies.", CardType.Attack, 8, 0)
    };
}
