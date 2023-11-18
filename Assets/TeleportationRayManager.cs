using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportationRayManager : MonoBehaviour
{

    public GameObject teleportationRay;
    public InputActionProperty teleportationActive;
    public InputActionProperty rightCancel;

    void Update()
    {
        teleportationRay.SetActive(rightCancel.action.ReadValue<float>() == 0 && teleportationActive.action.ReadValue<float>() > 0.1f);
    }
}
