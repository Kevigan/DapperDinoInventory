using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class ItemSlotUI : MonoBehaviour, IDropHandler
{
    [SerializeField] protected Image itemIconImage = null;

    public int SlotIndex { get; private set; }

    public abstract Item SlotItem { get; set; }

    private void OnEnable()
    {
        UpdateSlotUI();
    }

    protected virtual void Start()
    {
        SlotIndex = transform.GetSiblingIndex();
        Debug.Log(SlotIndex);
        UpdateSlotUI();
    }

    public abstract void OnDrop(PointerEventData eventData);

    public abstract void UpdateSlotUI();

    protected virtual void EnableSlotUI(bool enable)
    {
        itemIconImage.enabled = enable;
    }

    private void UpDateSlotUI()
    {
        throw new NotImplementedException();
    }
}
