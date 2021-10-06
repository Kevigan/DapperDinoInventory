using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem : Item
{
    [Header("Item Data")]
    [SerializeField] private Rarity rarity = null;
    [SerializeField] [Min(0)] private int sellPrice = 1;
    [SerializeField] [Min(1)] private int maxStack = 1;

    public override string ColouredName
    {
        get
        {
            string hexColour = ColorUtility.ToHtmlStringRGB(rarity.Colour);
            return $"<color=#{hexColour}>{Name}</color>";
        }
    }
    public int SellPrice { get => sellPrice; }
    public int MaxStack { get => maxStack; }
    public Rarity Rarity => rarity;
}
