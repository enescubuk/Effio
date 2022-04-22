using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class tilesetController : MonoBehaviour
{
    public Tilemap tiles;
    public Tile tile;
    public Vector3Int location;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log(Camera.main.ScreenPointToRay(Input.mousePosition));
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tiles.WorldToCell(pos);
            tiles.SetTile(location , tile);
            
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            location = tiles.WorldToCell(pos);
            Debug.Log(tiles.GetTile(location).name);
        }
    }
    
}
