using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class startUi : MonoBehaviour
{
    public Vector3Int location;
    public Vector3Int carLocation;
    public GameObject startFlag;
    public GameObject exitFlag;
    public Tilemap tiles;
    public GameObject car;
    public CarManager CarManager;
    void Start()
    {
        
    }

    void Update()
    {
        location = tiles.WorldToCell(startFlag.transform.position);
        carLocation = tiles.WorldToCell(car.transform.position);
        Debug.Log(location);
        Debug.Log(carLocation);
        if (carLocation == location)
        {
            if (CarManager.locationControl==true)
            {
                SceneManager.LoadScene("Level1");
            }
            StartCoroutine(asd());
        }
    }

    IEnumerator asd()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("asdasd");
    }
}
