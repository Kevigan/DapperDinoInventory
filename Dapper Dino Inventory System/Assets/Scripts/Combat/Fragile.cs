using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragile : MonoBehaviour, IDamageable
{
    public void DealDamage(int amount)
    {
        Destroy(gameObject);
    }
}
