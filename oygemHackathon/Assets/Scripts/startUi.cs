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
        if (carLocation == location)
        {
            if (CarManager.locationControl==true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            StartCoroutine(asd());
        }
    }

    IEnumerator asd()
    {
        yield return new WaitForSeconds(2);
    }
}
