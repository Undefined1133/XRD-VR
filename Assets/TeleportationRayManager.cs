using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationRayManager : MonoBehaviour
{

    public GameObject teleportationRay;
    public InputActionProperty teleportationActive;
    public InputActionProperty rightCancel;
    public XRRayInteractor ray;

    void Update()
    {
        bool isRayHovering = ray.TryGetHitInfo(out Vector3 pos, out Vector3 normal, out int number, out bool valid);
        teleportationRay.SetActive(!isRayHovering && rightCancel.action.ReadValue<float>() == 0 && teleportationActive.action.ReadValue<float>() > 0.1f);
    }
}
