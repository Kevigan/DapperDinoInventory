using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Rarity", menuName = "Items/Rarity")]
public class Rarity : ScriptableObject
{
    [SerializeField] private new string name = "New Rarity Name";
    [SerializeField] private Color colour = new Color(1f, 1f, 1f, 1f);

    public string Name { get => name; }

    public Color Colour { get => colour; }
    
}
