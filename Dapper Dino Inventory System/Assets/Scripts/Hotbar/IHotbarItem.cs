using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHotbarItem 
{
    string Name { get; }
    Sprite Icon { get; }
    void Use();
}
