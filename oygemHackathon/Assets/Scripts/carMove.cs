using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class carMove : MonoBehaviour
{
    Vector2 nextPos;
    public tilesetController tileScript;
    public float speed;
    int counter;

    public Tilemap tilemap;

    Vector3Int dsa ;
    bool start;
    
    // Start is called before the first frame update
    void Start()
    {
        tilemap = tileScript.tiles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            nearestNextPos();
            start = true;
        }
        if (start == true)
        {
            transform.position = Vector2.MoveTowards(transform.position,nextPos,speed * Time.deltaTime);
        }
        
        //Debug.Log(nextPos);
        if (Vector2.Distance(gameObject.transform.position, nextPos) <= 0.1f)
            {
                counter++;
                tileScript.points.Remove(tileScript.points[counter]);
                nearestNextPos();
            
            }
    }

    public void nearestNextPos()
    {
        Transform tMin = null;
        float minDist = Mathf.Infinity;
        for (int i = 0; i < tileScript.points.Count; i++)
        {
            float dist = Vector2.Distance(tileScript.points[i].transform.position, transform.position); 
            
            if (dist < minDist)
            {
                
                if (dist > 1  )
                {
                    tMin = tileScript.points[i].transform;
                    minDist = dist;
                }
            }
            
        }
        Debug.Log(minDist);
        //Debug.Log(tMin.position);
        nextPos = tMin.position;
        Vector3 asd = new Vector3(transform.position.x,transform.position.y,0);
        //Vector3Int dsa = Vector3Int.RoundToInt(asd);
        dsa = tilemap.WorldToCell(asd); 
        
        //Debug.Log(asd);
    }
}
