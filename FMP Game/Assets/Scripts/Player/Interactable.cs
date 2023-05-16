using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Interactable : MonoBehaviour
{

    [Header("Interact Script")]
    // adds/removes an InteractionEvent to the gameobject
    public bool useEvents;
    
    //displays message to player when looking at interactable
    [SerializeField]
    public string promptMessage;

    //will be called by the player
    public void baseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }
    protected virtual void Interact()
    {
        /* No code written here
        * Template function will be overridden by subclasses
        */ 
    }
}
