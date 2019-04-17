using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    const float
        degreesPerHour = 30f,
        degreesPerMinute = 6f,
        degreesPerSecond = 6f;

    public Transform hoursTransform, minutesTransform, secondsTransform;

    void Awake()
    {
        hoursTransform.localRotation =
            Quaternion.Euler(0f, DateTime.Now.Hour * degreesPerHour, 0f);
    }
}
