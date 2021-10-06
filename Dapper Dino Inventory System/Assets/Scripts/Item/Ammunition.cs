using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

[CreateAssetMenu(fileName = "New Ammunition Item", menuName = "Items/Ammunition Item")]
public class Ammunition : InventoryItem
{
    [SerializeField] private GameObject ammunitionPrefab = null;

    public GameObject AmmunitionPrefab => ammunitionPrefab;
    public override string GetInfoDisplayText()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append(Rarity.name).AppendLine();
        builder.Append("Max Stack: ").Append(MaxStack).AppendLine();
        builder.Append("Sell Price: ").Append(SellPrice).Append(" Gold");
        return builder.ToString();
    }
}
