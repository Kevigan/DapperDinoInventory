using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    [SerializeField] private Inventory inventory = null;
    [SerializeField] private TextMeshProUGUI areYouSuretext = null;

    private int slotIndex = 0;

    private void OnDisable()
    {
        slotIndex = -1;
    }

    public void Activate(ItemSlot itemSlot, int slotIndex)
    {
        this.slotIndex = slotIndex;

        areYouSuretext.text = $"Are you sure you wish to destroy {itemSlot.quantity}x {itemSlot.item.ColouredName}";

        gameObject.SetActive(true);
    }

    public void Destroy()
    {
        inventory.RemoveAt(slotIndex);

        gameObject.SetActive(false);
    }
}
