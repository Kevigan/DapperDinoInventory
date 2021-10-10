using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerCharacter2D : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private VoidEvent onCharacterJump;
    [SerializeField] private UnityEvent useNumerOne;
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

    //public void CheckForInteractable()
    //{
    //    if (currentInteractable == null) return;

    //    currentInteractable.Interact(gameObject);
    //}
    #region PlayerInput
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

    public void NumberOneInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            useNumerOne.Invoke();
        }
    }
    public void NumberTwoInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberThreeInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberFourInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberFiveInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberSixInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberSevenInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberEightInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberNineInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }
    public void NumberZeroInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {

        }
    }

    public void ToggleInventory(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            inventory.SetActive(!inventory.activeSelf);
        }
    }
    #endregion
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
