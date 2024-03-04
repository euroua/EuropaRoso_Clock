using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot; //pivot transform information
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
   
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation =
			Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation =
            Quaternion.Euler(0, 0, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation =
            Quaternion.Euler(0, 0, secondsToDegrees * (float)time.TotalSeconds);
    }

   
}
