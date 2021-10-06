using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Element", menuName = "Magic/Element")]
public class Element : ScriptableObject
{
    [SerializeField] private new string name = "New Element Name";
    [SerializeField] private Color colour = new Color(1f, 1f, 1f, 1f);

    public string Name { get => name; }

    public Color Colour { get => colour; }

}
