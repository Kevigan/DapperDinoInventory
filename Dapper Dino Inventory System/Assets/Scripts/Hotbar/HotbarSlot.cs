using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class HotbarSlot : ItemSlotUI, IDropHandler
{
    [SerializeField] private Inventory inventory = null;
    [SerializeField] private TextMeshProUGUI itemQuantityText = null;

    private Item slotItem = null;

    public override Item SlotItem
    {
        get { return slotItem; }
        set { slotItem = value; UpdateSlotUI(); }
    }

    public bool AddItem(Item itemToAdd)
    {
        if (slotItem != null) return false;

        slotItem = itemToAdd;

        return true;
    }

    public void UseSlot(int index)
    {
        if (index != SlotIndex) return;
        Debug.Log("1");
        //Use item
    }

    public override void OnDrop(PointerEventData eventData)
    {
        ItemDragHandler itemDragHandler = eventData.pointerDrag.GetComponent<ItemDragHandler>();
        if (itemDragHandler == null) return;
        
        InventorySlot inventorySlot = itemDragHandler.ItemSlotUI as InventorySlot;

        if(inventorySlot != null /*|| !slotItem.isHotbarUseable*/)
        {
            SlotItem = inventorySlot.ItemSlot.item;
            return;
        }

        HotbarSlot hotbarSlot = itemDragHandler.ItemSlotUI as HotbarSlot;
        if(hotbarSlot != null)
        {
            Item oldItem = SlotItem;
            SlotItem = hotbarSlot.SlotItem;
            hotbarSlot.SlotItem = oldItem;
            return;
        }
    }

    public override void UpdateSlotUI()
    {
        if(SlotItem == null || !slotItem.isHotbarUseable)
        {
            EnableSlotUI(false);
            return;
        }

        itemIconImage.sprite = slotItem.Icon;

        EnableSlotUI(true);

        SetItemQuantityUI();
    }

    private void SetItemQuantityUI()
    {
        if(slotItem is InventoryItem inventoryItem)
        {
            if (inventory.HasItem(inventoryItem))
            {
                int quantityCount = inventory.GetTotalQuantity(inventoryItem);
                itemQuantityText.text = quantityCount > 1 ? quantityCount.ToString() : "";
            }
            else
            {
                SlotItem = null;
            }
        }
        else
        {
            itemQuantityText.enabled = false;
        }
    }

    protected override void EnableSlotUI(bool enable)
    {
        base.EnableSlotUI(enable);
        itemQuantityText.enabled = enable;
    }
}
