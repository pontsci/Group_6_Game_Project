﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    public List<GameObject> interactableGameObjectsInRange;
    public InteractSphere interactSphereScript;

    private void Start()
    {
        interactableGameObjectsInRange = interactSphereScript.interactableGameObjectsInRange;
    }

    public void ActivateInteractableAtZeroIndex(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if(interactableGameObjectsInRange.Count != 0)
            {
                //activate our interactable object
                Debug.Log("Activate this " + interactableGameObjectsInRange[0] + "!");
                var interactable = interactableGameObjectsInRange[0].gameObject.GetComponent<Interactable>();
                interactable.Activate(context);
            }
        }
    }

    public void RemoveInteractableFromInteractableGameObjectsInRange(GameObject obj)
    {
        interactSphereScript.interactableGameObjectsInRange.Remove(obj);
    }

    public void AddInteractableFromInteractableGameObjectsInRange(GameObject obj)
    {
        interactSphereScript.interactableGameObjectsInRange.Add(obj);
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }
}
