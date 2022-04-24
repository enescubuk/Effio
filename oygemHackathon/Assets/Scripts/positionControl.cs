using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class positionControl : MonoBehaviour
{
    public Text coinText;
    private int coin = 120;
    public GameObject panel;
    public Tilemap tiles;
    public Tile[] tile;
    public Vector3Int location;
    public bool isOpen;
    public GameObject whichPoint;
    public tilesetController tileScript;
    int decrease;
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
                    if (tiles.GetTile(location).name.Contains("Asp") == true)
                    {
                        Debug.Log("asfalttı");
                        decrease = 50;
                    }
                    if (tiles.GetTile(location).name.Contains("Dirt") == true)
                    {
                        Debug.Log("dirttü");
                        decrease = 30;
                    }
                    if (tiles.GetTile(location).name.Contains("Ice") == true)
                    {
                        Debug.Log("icetı");
                        decrease = 90;
                    }
                }
            }
            
        }
        coinText.text = "" + coin;
    }

    public void path1()
    {
        coin -= 50;
        panel.SetActive(false);
        
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu1");
            coin += decrease;
        }
        tiles.SetTile(location, tile[0]);
        isOpen = false;
    }
    public void path2()
    {
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu2");
            coin += decrease;
        }
        tiles.SetTile(location, tile[1]);
        isOpen = false;
    }
    public void path3()
    {
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu3");
            coin += decrease;
        }
        tiles.SetTile(location, tile[2]);
        isOpen = false;
    }
    public void path4()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu4");
            coin += decrease;
        }
        tiles.SetTile(location, tile[3]);
        isOpen = false;
    }
    public void path5()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu5");
            coin += decrease;
        }
        tiles.SetTile(location, tile[4]);
        isOpen = false;
    }
    public void path6()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu6");
            coin += decrease;
        }
        tiles.SetTile(location, tile[5]);
        isOpen = false;
    }
    public void path7()
    {
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu7");
            coin += decrease;
        }
        tiles.SetTile(location, tile[6]);
        isOpen = false;
    }
    public void path8()
    {
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu8");
            coin += decrease;
        }
        tiles.SetTile(location, tile[7]);
        isOpen = false;

    }
    public void path9()
    {
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu9");
            coin += decrease;
        }
        tiles.SetTile(location, tile[8]);
        isOpen = false;

    }
    public void path10()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name == "bosyol_4")
        {
            Debug.Log("boştu");
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            Debug.Log("doluydu10");
            coin += decrease;
        }
        tiles.SetTile(location, tile[9]);
        isOpen = false;
    }
}
