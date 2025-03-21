using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedPressedPickUp : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool PickUpPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        PickUpPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        PickUpPressed = false;
    }
}
