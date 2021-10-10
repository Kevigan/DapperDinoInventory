using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOnContact : MonoBehaviour
{
    [SerializeField] private int amount = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var healable = collision.GetComponent<IHealable>();

        if (healable == null) return;

        healable.Heal(amount);
    }
}
