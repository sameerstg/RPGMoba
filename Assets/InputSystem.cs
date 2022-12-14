using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputSystem : MonoBehaviour
{
    public static InputSystem _instance;
    InputManager inputManager;
    public List<DelegateAction> leftClickActions = new List<DelegateAction>();
    private void Awake()
    {
        _instance = this;
        inputManager = new InputManager();

    }
    private void OnEnable()
    {
        inputManager.Enable();
        inputManager.Player.LeftClick.started += LeftClick;

    }
    private void OnDisable()
    {
        inputManager.Disable();

        inputManager.Player.LeftClick.started -= LeftClick;

    }

    private void LeftClick(InputAction.CallbackContext obj)
    {
        foreach (var item in leftClickActions)
        {
            item();
        }
    }
    public delegate void DelegateAction();

}

