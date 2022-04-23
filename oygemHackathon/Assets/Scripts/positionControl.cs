using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class positionControl : MonoBehaviour
{
    public Text coinText;
    private int coin=120;
    public GameObject panel;
    public Tilemap tiles;
    public Tile[] tile;
    public Vector3Int location;
    public bool isOpen;
    public GameObject whichPoint;
    public tilesetController tileScript;

    bool isChange;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isOpen == false)
        {
            panel.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tiles.WorldToCell(panel.transform.position);
            panel.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, 0);
            if (tiles.GetTile(location).name != null)
            {
                panel.SetActive(true);
                isOpen = true;
                if (tiles.GetTile(location).name != "bosyol_4")
                {
                    isChange = true;
                    Debug.Log(31);
                }
            }
        }
        coinText.text = "" + coin;
    }

    public void path1()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 50;
        panel.SetActive(false);
        tiles.SetTile(location, tile[0]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
    public void path2()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 50;
        panel.SetActive(false);
        tiles.SetTile(location, tile[1]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
    public void path3()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 50;
        panel.SetActive(false);
        tiles.SetTile(location, tile[2]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
    public void path4()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 90;
        panel.SetActive(false);
        tiles.SetTile(location, tile[3]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
    public void path5()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 90;
        panel.SetActive(false);
        tiles.SetTile(location, tile[4]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
    public void path6()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 90;
        panel.SetActive(false);
        tiles.SetTile(location, tile[5]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
    public void path7()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 30;
        panel.SetActive(false);
        tiles.SetTile(location, tile[6]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
    public void path8()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 30;
        panel.SetActive(false);
        tiles.SetTile(location, tile[7]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
        
    }
    public void path9()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 30;
        panel.SetActive(false);
        tiles.SetTile(location, tile[8]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
        
    }
    public void path10()
    {
        if (isChange == true)
        {
            Debug.Log(32);
            tiles.SetTile(location, null);
        }
        coin -= 120;
        panel.SetActive(false);
        tiles.SetTile(location, tile[9]);
        GameObject point = Instantiate(whichPoint);
        point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
        tileScript.points.Add(point);
        isOpen = false;
    }
}
