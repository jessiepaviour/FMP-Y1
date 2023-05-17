using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshot : MonoBehaviour
{
    public Rigidbody projectile;
    public GameObject barrelEnd;

    public float speed = 20;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                           transform.position,
                                                           transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
    }
}

