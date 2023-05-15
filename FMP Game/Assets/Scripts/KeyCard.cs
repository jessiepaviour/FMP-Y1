using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : Interactable
{
    public GameObject redKey;
    public GameObject blueKey;
    public GameObject greenKey;

    public string keyInUse;
    public void OnInteract()
    {
        keyInUse.ToUpper();

        if (keyInUse == "REDKEY")
        {

        }
        if (keyInUse == "BLUEKEY")
        {

        }
        if (keyInUse == "GREENKEY")
        {

        }
    }
}
