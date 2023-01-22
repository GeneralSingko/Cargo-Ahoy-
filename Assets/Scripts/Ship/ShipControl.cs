using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public UserInput input;
    public Ship player;

    private void Awake()
    {
        input = new UserInput();
    }

    private void OnEnable()
    {
        input.Sailing.Enable();
    }

    private void OnDisable()
    {
        input.Sailing.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Ship>();

        UserInput.SailingActions action = input.Sailing;
        
        action.Steer.performed += _ => player.Steer(action.Steer.ReadValue<float>());
        action.Steer.canceled += _ => player.StopSteer();

        action.SpeedUp.performed += _ => player.GearUp();
        action.SlowDown.performed += _ => player.GearDown();
    }


}
