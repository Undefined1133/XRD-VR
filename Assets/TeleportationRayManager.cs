using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportationRayManager : MonoBehaviour
{

    public GameObject teleportationRay;
    public InputActionProperty teleportationActive;

    void Update()
    {
        teleportationRay.SetActive(teleportationActive.action.ReadValue<float>() > 0.1f);
    }
}
