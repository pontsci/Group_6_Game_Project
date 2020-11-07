﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialOnEnterInteract : MonoBehaviour
{

    public Material interactiveMaterial;
    public Material defaultMaterial;

    private Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
    }

    void ChangeToDefaultMaterial()
    {
        rend.material = defaultMaterial;
    }

    void ChangeToInteractiveMaterial()
    {
        rend.material = interactiveMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "InteractSphere")
        {
            Debug.Log("Detected Interactable Sphere!");
            ChangeToInteractiveMaterial();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "InteractSphere")
        {
            Debug.Log("Detected Leaving Interactable Sphere!");
            ChangeToDefaultMaterial();
        }
    }
}