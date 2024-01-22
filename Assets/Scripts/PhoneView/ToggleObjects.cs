using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class ToggleObjects : MonoBehaviour
{
    public List<GameObject> objectsToToggle; // List of objects to toggle
    private bool areObjectsActive = true; // Track the active state
    private InputAction toggleAction; // Input action for toggling objects

    void Awake()
    {
        // Create the input action for toggling
        toggleAction = new InputAction(binding: "<Keyboard>/q");
        toggleAction.AddBinding("<Gamepad>/rightStickPress");

        // Subscribe to the performed event
        toggleAction.performed += ctx => ToggleObjectsActive();
    }

    void OnEnable()
    {
        toggleAction.Enable();
    }

    void OnDisable()
    {
        toggleAction.Disable();
    }

    private void ToggleObjectsActive()
    {
        Debug.Log("Toggle action performed");
        foreach (var obj in objectsToToggle)
        {
            if (obj != null)
            {
                obj.SetActive(!areObjectsActive);
            }
        }
        areObjectsActive = !areObjectsActive;
    }
}
