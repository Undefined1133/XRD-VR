using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public Transform head;
    public float spawnDistance = 2f;
    public InputActionProperty showButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
            var forward = head.forward;
            menu.transform.position =
                head.position + new Vector3(forward.x, 0, forward.z).normalized * spawnDistance;
        }

        var position = head.position;
        menu.transform.LookAt(new Vector3(position.x, position.y, position.z));
        menu.transform.forward *= -1;
    }
}
