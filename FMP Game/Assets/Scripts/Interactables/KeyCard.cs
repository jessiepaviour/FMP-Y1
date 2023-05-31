using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyCard : Interactable
{
    [SerializeField]
    private GameObject console;
    private bool doorOpen;

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        console.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
