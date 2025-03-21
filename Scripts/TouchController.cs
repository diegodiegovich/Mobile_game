using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public FixedTouchField _FixedTouchField;
    public CameraLook _CameraLook;
    public PlayerMove _PlayerMove;
    public FixedButton _FixedButton;

    public PickUp _PickUp;
    public FixedPressedPickUp _FixedPressedPickUp;

    public PickOff _PickOff;
    public FixedPressedDropOff _FixedPressedDropOff;

    void Start()
    {

    }


    void Update()
    {
        _CameraLook.LockAxis = _FixedTouchField.TouchDist;
        _PlayerMove.Pressed = _FixedButton.Pressed;
        _PickUp.Pressed = _FixedPressedPickUp.PickUpPressed;
        _PickOff.PressedOff = _FixedPressedDropOff.PickedOffPressed;
    }
}
