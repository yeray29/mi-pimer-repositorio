using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class interactable : MonoBehaviour
{
    public UnityEvent interactionEvent;

    public void interact()
    {
        if (interactionEvent != null)
        {
            interactionEvent.Invoke();
        }
    }
}