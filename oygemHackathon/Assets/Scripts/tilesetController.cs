using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class tilesetController : MonoBehaviour
{
    public CarManager carScript;

    public Tilemap tiles;
    public Tile tile;
    public Vector3Int location;

    public GameObject movePoint;

    public List<GameObject> points;

    public GameObject[] whichPoint;

    public positionControl posScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && posScript.isOpen == false)
        {
            

            /*
            //Debug.Log(Camera.main.ScreenPointToRay(Input.mousePosition));
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tiles.WorldToCell(pos);
            

            tiles.SetTile(location , tile);
            
            
            GameObject point = Instantiate(whichPoint[0]);

            point.transform.position = new Vector3(tiles.CellToWorld(location).x, tiles.CellToWorld(location).y+0.5f, tiles.CellToWorld(location).z);

            points.Add(point);*/
            

        }
        else if (Input.GetMouseButtonDown(1))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tiles.WorldToCell(pos);
            
        }
    }
}
