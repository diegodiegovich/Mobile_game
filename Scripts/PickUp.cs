using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Rigidbody rb;
    public bool Pressed;
    public RaycastHit hit;
    public float Speed = 2f;
    public GameObject DropOff;
    public Camera PlayerCamera;
    public float Range = 5f;
    public LayerMask mask;
    public GameObject Target;

    public void Update()
    {
        if (Pressed)
        {
            DropOff.SetActive(true);

            /*   if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, Range, mask))
               {
                   rb = hit.rigidbody;
                   rb.useGravity = false;
               }
            */

            Ray CameraRay = PlayerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast(CameraRay, out hit, Range, mask))
            {
                rb = hit.rigidbody;
                rb.useGravity = false;
            }
        }
    }
    public void FixedUpdate()
    {
        if (rb)
        {
            Vector3 Direct = Target.transform.position - rb.position;
            float Distance = Direct.magnitude;
            rb.velocity = Direct * Speed * Distance;
        }
    }
}
