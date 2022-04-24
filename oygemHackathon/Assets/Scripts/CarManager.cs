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
                    tileScript.points.Remove(tileScript.points[i]);
                    i++;
                }

            }
        }
       
        if (Input.GetKeyDown(KeyCode.A))
        {
            tileScript.points.Add(nullGameobject);
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
        if (tileScript.tiles.GetTile(carGrid).name.Contains(""))
        {
            Debug.Log("baba");
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
