using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Item", menuName = "Items / Weapon Item")]
public class Weapon : InventoryItem
{
    [Header("Weapon Data")]
    [SerializeField] private string useText = "Does somethin, maybe?";

    public override string GetInfoDisplayText()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append(Rarity.name).AppendLine();
        builder.Append(Name).AppendLine();
        builder.Append("<color=green>Use: ").Append(useText).Append("</color>").AppendLine();
        builder.Append("Max Stack: ").Append(MaxStack).AppendLine();
        builder.Append("Sell Price: ").Append(SellPrice).Append(" Gold");
        return builder.ToString();
    }

    
}
