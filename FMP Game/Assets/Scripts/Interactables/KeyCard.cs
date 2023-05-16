using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : Interactable
{
    [Header("KeyCard")]
    public GameObject redKey;
    public GameObject blueKey;
    public GameObject greenKey;
    public GameObject standardKey;

    public string keyInUse;

    private void Start()
    {
        redKey.SetActive(false); 
        blueKey.SetActive(false);
        greenKey.SetActive(false);
        standardKey.SetActive(false);
    }
    protected override void Interact()
    {
        keyInUse.ToUpper();

        if (keyInUse == "RED")
        {
            redKey.SetActive(true);
        }
        else if (keyInUse == "BLUE")
        {
            blueKey.SetActive(true);
        }
        else if (keyInUse == "GREEN")
        {
            greenKey.SetActive(true);
        }
        else if (keyInUse == "STANDARD")
        {
            standardKey.SetActive(true);
        }
    }
}
