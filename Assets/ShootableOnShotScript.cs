using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class ShootableOnShotScript : MonoBehaviour
{
    private PointSystemSingleton pointSystemSingleton;
    private void Start()
    {
        pointSystemSingleton = PointSystemSingleton.instance;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            pointSystemSingleton.AddPoint();
            Destroy(gameObject);
        }
    }

}
