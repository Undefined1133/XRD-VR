using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointSystemSingleton : MonoBehaviour
{
    public static PointSystemSingleton instance;
    public TextMeshProUGUI pointsText;
    public int points = 0;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ResetPoints()
    {
        points = 0;
        pointsText.SetText("Points: " + points);
    }

    public void AddPoint()
    {
        points++;
        pointsText.SetText("Points: " + points);

    }
}
