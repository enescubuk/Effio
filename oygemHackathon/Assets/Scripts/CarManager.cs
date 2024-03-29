using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class CarManager : MonoBehaviour
{
    public GameObject smoke;
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
        nullGameobject = GameObject.Find("GameObject");
        tileScript = GameObject.Find("Main Camera").GetComponent<tilesetController>();
        
        //Vector2.Lerp(gameObject.transform.position, tileScript.points[0].transform.position, speed);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (GetComponent<SpriteRenderer>().sprite == sprites[0])
        {
            smoke.transform.localPosition = new Vector3(0.16f, 0.14f, 0);
        }
        if (GetComponent<SpriteRenderer>().sprite == sprites[1])
        {
            smoke.transform.localPosition = new Vector3(0.16f, -0.14f, 0);
        }
        if (GetComponent<SpriteRenderer>().sprite == sprites[2])
        {

            smoke.transform.localPosition = new Vector3(-0.16f, -0.14f, 0);
        }
        if (GetComponent<SpriteRenderer>().sprite == sprites[3])
        {
            smoke.transform.localPosition = new Vector3(-0.16f, 0.14f, 0);
        }
        
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
                        

                        if (a.Contains("4") && a != "bosyol_4")
                        {
                        
                            if (GetComponent<SpriteRenderer>().sprite == sprites[0])
                            {
                                GetComponent<SpriteRenderer>().sprite = sprites[3];
                                
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
       
        if (tiles.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)) == tiles.WorldToCell(GameObject.Find("red_2").transform.position) && Input.GetMouseButtonDown(0))
        {
            speed = 1;
            tileScript.points.Add(nullGameobject);
            nullGameobject.transform.position = GameObject.Find("bayraklar_0").transform.position;
            
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
                transform.position = Vector2.MoveTowards(gameObject.transform.position, tileScript.points[0].transform.position, (speed) * Time.deltaTime);   
            }
            
               // transform.position = Vector2.MoveTowards(gameObject.transform.position, tileScript.points[0].transform.position, speed * Time.deltaTime);
                

        }

    }
    void speedChange()
    {
        Debug.Log("girdi");
        Vector3Int carGrid = tileScript.tiles.WorldToCell(transform.position);
        if (tileScript.tiles.GetTile(carGrid).name.Contains("Asp"))
        {
            float newSpeed = speed * 60;
            newSpeed = newSpeed - 20;
            if (newSpeed >= 0)
            {
                speed = newSpeed / 60;
            }
        }
        if (tileScript.tiles.GetTile(carGrid).name.Contains("Dirt"))
        {
            float newSpeed = speed * 60;
            newSpeed = newSpeed - 30;
            if (newSpeed >= 0)
            {
                speed = newSpeed / 60;
            }
        }
        if (tileScript.tiles.GetTile(carGrid).name.Contains("Ice"))
        {
            float newSpeed = speed * 60;
            newSpeed = newSpeed + 30;
            if (newSpeed >= 0)
            {
                speed = newSpeed / 60;
            }
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