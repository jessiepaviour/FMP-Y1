using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    public PlayerInput.OnFootActions onFoot;
    
    private PlayerMotor motor;
    private PlayerLook look;
    // Start - called before the first frame
    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;

        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();

        onFoot.Jump.performed += ctx => motor.Jump();
    }

    // Update - called once per frame
    void FixedUpdate()
    {
        //tells PlayerMotor to move
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }
    void LateUpdate()
    {
        //tells PlayerMotor to move
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }
}
