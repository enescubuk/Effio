using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedIndicator : MonoBehaviour
{
    public CarManager carManager;
    public GameObject needle;
    public float vehicleSpeed;

    private  float startPosition=270f, endPosition=-49f;
    private float desiredPosition;
    private float indicatorSpeed;




    void Start()
    {
       
    }

    void FixedUpdate()
    {
        vehicleSpeed = carManager.speed*30;
        updateNeedle();

    }

    public void updateNeedle()
    {
        desiredPosition = startPosition - endPosition;
        float temp = vehicleSpeed / 180;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * desiredPosition));
    }
}
