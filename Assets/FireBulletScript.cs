using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletScript : MonoBehaviour
{

    public GameObject bullet;

    public Transform spawnPoint;

    public float fireSpeed;

    public AudioClip shootClip;
    public AudioSource audioSource;

    void Start()
    {
        XRGrabInteractable interactable = GetComponent<XRGrabInteractable>();
        interactable.activated.AddListener(FireBullet);
        InvokeRepeating(nameof(AutoFire), 0f, 3f);
    }

    public void FireBullet(ActivateEventArgs args)
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);
        
        if (audioSource != null && shootClip != null)
        {
            audioSource.PlayOneShot(shootClip);
        }
    }
    
    private void AutoFire()
    {
        GameObject spawnedBullet = Instantiate(bullet);
        spawnedBullet.transform.position = spawnPoint.position;
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnedBullet, 5);
        if (audioSource != null && shootClip != null)
        {
            audioSource.PlayOneShot(shootClip);
        }
    }
}
