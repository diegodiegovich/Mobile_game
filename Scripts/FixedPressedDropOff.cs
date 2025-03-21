using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedPressedDropOff : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool PickedOffPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        PickedOffPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        PickedOffPressed = false;
    }
}
