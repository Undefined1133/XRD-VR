using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{

    public GameObject grabRay;

    public XRDirectInteractor directGrab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        grabRay.SetActive(directGrab.interactablesSelected.Count == 0);
    }
}
