using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : ScriptableObject, IHotbarItem
{
    [Header("Basic Info")]
    [SerializeField] private new string name = "New Spell Name";
    [SerializeField] private Sprite icon = null;
    [SerializeField] private Element element = null;

    public Element Element => element;
    public string Name => name;

    public Sprite Icon => icon;

    public void Use()
    {
        Debug.Log($"Casting {Name}");
    }

    
}
