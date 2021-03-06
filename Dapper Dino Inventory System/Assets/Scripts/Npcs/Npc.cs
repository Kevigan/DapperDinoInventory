using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour, IInteractable
{
    [SerializeField] private NpcEvent onStartInteraction = null;
    [SerializeField] private new string name = "New Npc Name";
    [SerializeField] private string greetingText = "Hello adventurer!";

    private GameObject otherInteractor = null;
    public GameObject OtherInteractor => otherInteractor;

    private IOccupation[] occupations = new IOccupation[0];

    public string Name => name;
    public string GreetingText => greetingText;
    public IOccupation[] Occupations => occupations;


    private void Start()
    {
        occupations = GetComponents<IOccupation>();
    }
    public void Interact(GameObject other)
    {
        otherInteractor = other;

        onStartInteraction.Raise(this);
    }
}
