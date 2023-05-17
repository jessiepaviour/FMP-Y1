using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyCard : Interactable
{
    [Header("KeyCard")]
    public GameObject redKey;
    public GameObject blueKey;
    public GameObject greenKey;
    public GameObject standardKey;

    public string keyInUse;

    [SerializeField]
    private GameObject console;
    private bool doorOpen;

    private void Start()
    {
        redKey.SetActive(false); 
        blueKey.SetActive(false);
        greenKey.SetActive(false);
        standardKey.SetActive(false);
    }
    protected override void Interact()
    {
        //keyInUse.ToUpper();

        //if (keyInUse == "RED")
        //{
        //    redKey.SetActive(true);
        //}
        
        //if (keyInUse == "BLUE")
        //{
        //    blueKey.SetActive(true);
        //}
        
        //if (keyInUse == "GREEN")
        //{
        //    greenKey.SetActive(true);
        //}
        
        //if (keyInUse == "STANDARD")
        //{
        //    standardKey.SetActive(true);
        //}

        doorOpen = !doorOpen;
        console.GetComponent<Animator>().SetBool("IsOpen", doorOpen);
    }
}
