using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VendorItemButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemNametext = null;
    [SerializeField] private Image itemIconImage = null;

    private VendorSystem vendorSystem = null;
    private InventoryItem item = null;

    public void Initialise(VendorSystem vendorSystem, InventoryItem item, int quantity)
    {
        this.vendorSystem = vendorSystem;
        this.item = item; 
        itemNametext.text = $"{item.Name} ({quantity})";
        itemIconImage.sprite = item.Icon;
    }

    public void SelectItem()
    {
        vendorSystem.SetItem(item);
    }
}
