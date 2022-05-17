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

    public positionControl positionScript;

    public float firstStarLimit, secondStarLimit, thirdStarLimit;
    public GameObject[] stars;
    public GameObject finish_ui;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name.Contains("Select"))
        {
            positionScript.coinText.enabled = false;
        }
        positionScript = GameObject.Find("PositionControl").GetComponent<positionControl>();
        finish_ui.SetActive(false);
        stars[0].SetActive(false);
        stars[1].SetActive(false);
        stars[2].SetActive(false);
    }
    void Start()
    {
        
        
        
    }

    void Update()
    {
        location = tiles.WorldToCell(startFlag.transform.position);
        carLocation = tiles.WorldToCell(car.transform.position);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}

        if (carLocation == location || carLocation== tiles.WorldToCell(GameObject.Find("bayraklar_0").transform.position))
        {
            if (SceneManager.GetActiveScene().name.Contains("Select"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                //getStar();
            }
            
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            //    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //    getStar();
            //}
            getStar();
        }

    }

    public void getStar()
    {
        finish_ui.SetActive(true);
        Debug.Log("yildiz");
        if (positionScript.coin > firstStarLimit)
        {
            stars[0].SetActive(true);
        }
        if (positionScript.coin > secondStarLimit)
        {
            stars[1].SetActive(true);
        }
        if (positionScript.coin > thirdStarLimit)
        {
            stars[2].SetActive(true);
        }
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
