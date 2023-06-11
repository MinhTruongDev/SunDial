using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSun : MonoBehaviour
{
    [SerializeField] private bool isChanging = false;
    [SerializeField] private float latitude;
    [SerializeField] private float longitude;
    [SerializeField] private DateTime currentDate;
    [SerializeField] private DateTime Time;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isChanging)
        {
            MoveSun();
        }
    }

    private void MoveSun()
    {
        throw new NotImplementedException();
    }
}
