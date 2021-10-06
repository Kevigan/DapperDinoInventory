using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : MonoBehaviour, IOccupation
{
    [SerializeField] private VendorDataEvent onStartVendorScenario = null;
    public string Name => "Lets´s trade";

    private IItemContainer itemContainer = null;

    private void Start()
    {
        itemContainer = GetComponent<IItemContainer>();
    }

    public void Trigger(GameObject other)
    {
        var otherItemContainer = other.GetComponent<IItemContainer>();

        if (otherItemContainer == null) return;

        VendorData vendorData = new VendorData(otherItemContainer, itemContainer);

        onStartVendorScenario.Raise(vendorData);
    }
}
