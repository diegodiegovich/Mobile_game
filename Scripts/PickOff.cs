using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickOff : MonoBehaviour
{
    public bool PressedOff;
    public PickUp _PickUp;
    public GameObject DropOff;
 
    void Update()
    {
       if(PressedOff)
        {
            _PickUp.rb.useGravity= true;
            _PickUp.rb = null;
            Invoke("OFF", 0.5f);
        }
    }

    public void OFF()
    {
        DropOff.SetActive(false);
    }
}
