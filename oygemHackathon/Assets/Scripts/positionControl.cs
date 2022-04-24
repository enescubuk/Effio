using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class positionControl : MonoBehaviour
{
    public Text coinText;
    public int coin = 120;
    public GameObject panel;
    public Tilemap tiles;
    public Tile[] tile;
    public Vector3Int location;
    public bool isOpen;
    public GameObject whichPoint;
    public tilesetController tileScript;
    int decrease;
    bool isChange;

    public float firstStarLimit,secondStarLimit,thirdStarLimit;
    public GameObject[] stars;

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

            if (tiles.GetTile(location) == null)
            {
                
            }
            else
            {
                panel.SetActive(true);
                isOpen = true;
                if (tiles.GetTile(location).name != "bosyol_4")
                {
                    if (tiles.GetTile(location).name.Contains("Asp") == true)
                    {
                        
                        decrease = 50;
                    }
                    if (tiles.GetTile(location).name.Contains("Dirt") == true)
                    {
                        
                        decrease = 30;
                    }
                    if (tiles.GetTile(location).name.Contains("Ice") == true)
                    {
                        
                        decrease = 90;
                    }
                }
                
            }
            
        }
        coinText.text = "" + coin;
    }
    void star()
    {
        if (coin > firstStarLimit)
        {
            
            stars[0].SetActive(true);
        }
        if (coin > secondStarLimit)
        {
        
            stars[1].SetActive(true);
        }
        if (coin > thirdStarLimit)
        {
            
            stars[2].SetActive(true);
        }
    }

    public void path1()
    {
        coin -= 50;
        panel.SetActive(false);
        
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[0]);
        isOpen = false;
    }
    public void path2()
    {
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[1]);
        isOpen = false;
    }
    public void path3()
    {
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[2]);
        isOpen = false;
    }
    public void path4()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[3]);
        isOpen = false;
    }
    public void path5()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[4]);
        isOpen = false;
    }
    public void path6()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[5]);
        isOpen = false;
    }
    public void path7()
    {
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[6]);
        isOpen = false;
    }
    public void path8()
    {
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[7]);
        isOpen = false;

    }
    public void path9()
    {
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[8]);
        isOpen = false;

    }
    public void path10()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[9]);
        isOpen = false;
    }
    public void path11()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[10]);
        isOpen = false;
    }
    public void path12()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[11]);
        isOpen = false;
    }
    public void path13()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[12]);
        isOpen = false;
    }

    public void path14()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[13]);
        isOpen = false;
    }

    public void path15()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[14]);
        isOpen = false;
    }
    public void path16()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[15]);
        isOpen = false;
    }
    public void path17()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[16]);
        isOpen = false;
    }
    public void path18()
    {
        coin -= 120;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
        {
            
            GameObject point = Instantiate(whichPoint);
            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y + 0.5f, tiles.CellToWorld(location).z);
            tileScript.points.Add(point);
        }
        else
        {
            
            coin += decrease;
        }
        tiles.SetTile(location, tile[17]);
        isOpen = false;
    }

    public void closeButton()
    {
        panel.SetActive(false);
        isOpen = false;
    }
}