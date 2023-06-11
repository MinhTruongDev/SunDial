using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSun : MonoBehaviour
{
    [SerializeField] InputField latitudeInput;
    [SerializeField] InputField longitudeInput;
    [SerializeField] InputField currentDateInput;
    [SerializeField] InputField timeIpnut;


    [SerializeField] GameObject sun;
    [SerializeField] Light sunLight;

    [SerializeField] [Range(-90f, 90f)] private float latitude;
    [SerializeField] [Range(-180f, 180f)] private float longitude;
    [SerializeField] [Range(1, 31)] private int currentDate;
    [SerializeField] [Range(1, 12)] private int currentMonth;
    [SerializeField] [Range(1900, 2030)] private int currentYear;
    [SerializeField] [Range(1, 60)] private int second;
    [SerializeField] [Range(1, 60)] private int minute;
    [SerializeField] [Range(0, 24)] private int hour;

    [Range(0, 43200)] private float time;



    private void Start()
    {
        sun = gameObject;
        sunLight = gameObject.GetComponent<Light>();
    }
    // Update is called once per frame
    void Update()
    {
        MoveSun(latitude, longitude, currentDate, currentMonth, currentYear, hour, minute, second);

    }   

    private void MoveSun(float latitude, float longitude, int date, int month, int year, int hour, int minute, int second)
    {
        int tempMonth = FindSunHeight(month);
        time = (hour * 360) + (minute * 60) + second;
        sun.transform.localEulerAngles = new Vector3(Time.deltaTime * time, tempMonth * 40 * 0.2f, 0);
    }

   

    private static int FindSunHeight(int month)
    {

        if (month <= 3)
        {
            return 3;
        }
        else if (month <= 6 && month > 3)
        {
            return 6;
        }
        else if (month <= 9 && month > 6)
        {
            return 9;
        }
        else
        {
            return 12;
        }

    }
}
