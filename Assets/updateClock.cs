using System;
using UnityEngine;

public class updateClock : MonoBehaviour
{
    private int currentSecondOnClock;
    private int currentMinuteOnClock;
    private int currentHourOnClock;

    private GameObject analogSecond;
    private GameObject analogMinute;
    private GameObject analogHour;
    
    void Start()
    {
        GameObject[] analogs = GameObject.FindGameObjectsWithTag("Analog");

        foreach (GameObject analog in analogs) {
            if (analog.name == "Clock_Analog_A_Hour")
                analogHour = analog;
            if (analog.name == "Clock_Analog_A_Minute")
                analogMinute = analog;
            if (analog.name == "Clock_Analog_A_Second")
                analogSecond = analog;
        }
        currentHourOnClock = DateTime.Now.Hour;
        currentMinuteOnClock = DateTime.Now.Minute;
        currentSecondOnClock = DateTime.Now.Second;

        analogHour.transform.localEulerAngles = new Vector3(currentHourOnClock * 30, analogHour.transform.localEulerAngles.y, analogHour.transform.localEulerAngles.z);
        analogMinute.transform.localEulerAngles = new Vector3(currentMinuteOnClock * 6, analogMinute.transform.localEulerAngles.y, analogMinute.transform.localEulerAngles.z);
        analogSecond.transform.localEulerAngles = new Vector3(currentSecondOnClock * 6, analogSecond.transform.localEulerAngles.y, analogSecond.transform.localEulerAngles.z);
    }

    void Update()
    {
        int currentHour = DateTime.Now.Hour;
        int currentMinute = DateTime.Now.Minute;
        int currentSecond = DateTime.Now.Second;

        if (currentHourOnClock != currentHour) {
            currentHourOnClock = currentHour;
            analogHour.transform.Rotate(new Vector3(30, 0, 0));
        }

        if (currentMinuteOnClock != currentMinute) {
            currentMinuteOnClock = currentMinute;
            analogMinute.transform.Rotate(new Vector3(6, 0, 0));
        }

        if (currentSecondOnClock != currentSecond) {
            currentSecondOnClock = currentSecond;
            analogSecond.transform.Rotate(new Vector3(6, 0, 0));
        }
    }
}
