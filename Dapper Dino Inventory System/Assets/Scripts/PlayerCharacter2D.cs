using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacter2D : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private VoidEvent onCharacterJump;
    private Vector2 moveInput;
    public int speed = 5;

    private IInteractable currentInteractable = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.position += (Vector3)moveInput * Time.fixedDeltaTime * speed;
    }

    public void CheckForInteractable()
    {
        if (currentInteractable == null) return;

        currentInteractable.Interact(gameObject);
    }

    public void PlayerMoveInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void ShootInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            onCharacterJump.Raise();
        }
    }

    public void InteractInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            currentInteractable.Interact(gameObject);
        }

    }

    public void ToggleInventory(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            inventory.SetActive(!inventory.activeSelf);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var interactable = collision.GetComponent<IInteractable>();

        if (interactable == null) return;

        currentInteractable = interactable;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var interactable = collision.GetComponent<IInteractable>();

        if (interactable == null) return;

        if (interactable != currentInteractable) return;

        currentInteractable = null;
    }
}
