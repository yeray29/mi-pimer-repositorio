using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInterction : MonoBehaviour
{
    public float interctionDistance = 1;
    public Transform playerCamera;
    public LayerMask InteractableLayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            checkForInteractio();
        }
    }

    private void checkForInteractio()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out hitInfo, interctionDistance, InteractableLayer))
        {
            interactable interactable = hitInfo.collider.gameObject.GetComponent<interactable>();
            if (interactable != null)
            {
                interactable.interact();
            }
        }
    }
}