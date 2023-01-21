using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipControl : MonoBehaviour
{
    public ShipInput inputAction;
    public Ship player;

    private void Awake()
    {
        inputAction = new ShipInput();
    }

    private void OnEnable()
    {
        inputAction.Sailing.Enable();
    }

    private void OnDisable()
    {
        inputAction.Sailing.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Ship>();

        ShipInput.SailingActions action = inputAction.Sailing;
        
        action.Steer.performed += _ => player.Steer(inputAction.Sailing.Steer.ReadValue<float>());
        action.Steer.canceled += _ => player.StopSteer();

        action.SpeedUp.performed += _ => player.GearUp();
        action.SlowDown.performed += _ => player.GearDown();
    }


}
