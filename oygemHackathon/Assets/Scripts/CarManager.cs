using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CarManager : MonoBehaviour
{
    public tilesetController tileScript;
    public float speed;
    public bool locationControl;
    public bool start = false;

    public GameObject nullGameobject;
    public List<GameObject> points;

    public int i;
    public Vector3Int carLocation;

    public Tilemap tiles;
    public Tile[] tile;
    public Vector3Int location;

    public Sprite[] sprites;
    private string a;



    void Start()
    {
        
        tileScript = GameObject.Find("Main Camera").GetComponent<tilesetController>();
        //Vector2.Lerp(gameObject.transform.position, tileScript.points[0].transform.position, speed);
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (tileScript.points.Count!=0)
        {
            for (int i = 0; i < tileScript.points.Count; i++)
            {
            
                if (Vector2.Distance(gameObject.transform.position, tileScript.points[i].transform.position) <= 0.2f)
                {
                    
                    location = tiles.WorldToCell(tileScript.points[i].transform.position);
                    carLocation = tiles.WorldToCell(transform.position);
                    speedChange();
                    if (carLocation == location)
                    {
                        a = tiles.GetTile(location).name;
                        Debug.Log(a);

                        if (a.Contains("4") && a != "bosyol_4")
                        {
                        
                            if (GetComponent<SpriteRenderer>().sprite == sprites[0])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[3];
                                Debug.Log(69);
                            }
                            if (GetComponent<SpriteRenderer>().sprite == sprites[1])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[2];
                            }

                        }
                        if (a.Contains("3") && a != "bosyol_4")
                        {

                            if (GetComponent<SpriteRenderer>().sprite == sprites[2])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[1];
                                Debug.Log(69);
                            }
                            if (GetComponent<SpriteRenderer>().sprite == sprites[3])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[0];
                            }

                        }
                        if (a.Contains("5") && a != "bosyol_4")
                        {

                            if (GetComponent<SpriteRenderer>().sprite == sprites[3])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[2];
                                Debug.Log(69);
                            }
                            if (GetComponent<SpriteRenderer>().sprite == sprites[0])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[1];
                            }

                        }
                        if (a.Contains("6") && a != "bosyol_4")
                        {

                            if (GetComponent<SpriteRenderer>().sprite == sprites[2])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[3];
                                Debug.Log(69);
                            }
                            if (GetComponent<SpriteRenderer>().sprite == sprites[1])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[0];
                            }

                        }
                    }
                    tileScript.points.Remove(tileScript.points[i]);
                    i++;
                }

            }
        }
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            start = true;
        }
        if (start)
        {
            
            if (tileScript.points.Count == 0)
            {
                locationControl = true;
            }
            else
            {
                transform.position = Vector2.MoveTowards(gameObject.transform.position, tileScript.points[0].transform.position, speed * Time.deltaTime);   
            }
            
               // transform.position = Vector2.MoveTowards(gameObject.transform.position, tileScript.points[0].transform.position, speed * Time.deltaTime);
                

        }

    }
    void speedChange()
    {
        Vector3Int carGrid = tileScript.tiles.WorldToCell(transform.position);
        if (tileScript.tiles.GetTile(carGrid).name.Contains("Asp"))
        {
            //Debug.Log("asphalt");
            speed = speed - (speed/3);
        }
        if (tileScript.tiles.GetTile(carGrid).name.Contains("Dirt"))
        {
            Debug.Log("patika");
            speed = speed - (speed/2);
        }
        if (tileScript.tiles.GetTile(carGrid).name.Contains("Ice"))
        {
            Debug.Log("buz");
            speed = speed - (2*speed/3);
        }
    }
    Transform GetClosestPoint(List<GameObject> enemies)
    {
        

        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (GameObject t in enemies)
        {

                float dist = Vector3.Distance(t.transform.position, currentPos);
                Debug.Log(t.transform.position.x);
                if (dist < minDist)
                {

                //potentialTiles.Add(t);

                    tMin = t.transform;
                    minDist = dist;
                }

        }
       
        return tMin;
    }
   

}
