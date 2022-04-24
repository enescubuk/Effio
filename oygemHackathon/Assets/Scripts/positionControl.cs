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

            if (tiles.GetTile(location) == null || tiles.GetTile(location).name.Contains("coguburda_2") || tiles.GetTile(location).name.Contains("tas"))
            {
                Debug.Log(31);
            }
            else
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
        coin -= 30;
        panel.SetActive(false);
        
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 30;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
    public void path11()
    {
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[10]);
        isOpen = false;
    }
    public void path12()
    {
        coin -= 50;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[11]);
        isOpen = false;
    }
    public void path13()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[12]);
        isOpen = false;
    }

    public void path14()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[13]);
        isOpen = false;
    }

    public void path15()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[14]);
        isOpen = false;
    }
    public void path16()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[15]);
        isOpen = false;
    }
    public void path17()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[16]);
        isOpen = false;
    }
    public void path18()
    {
        coin -= 90;
        panel.SetActive(false);
        if (tiles.GetTile(location).name.Contains("bosyol_4"))
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
        tiles.SetTile(location, tile[17]);
        isOpen = false;
    }

    public void closeButton()
    {
        panel.SetActive(false);
        isOpen = false;
    }
}
