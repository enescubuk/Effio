using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public bool onWall;
    public LayerMask tileLayer;
    public float carRayCastLength;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onWall = Physics2D.Raycast(transform.position, Vector2.down, carRayCastLength, tileLayer);
    }
}
