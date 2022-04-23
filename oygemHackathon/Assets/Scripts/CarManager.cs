using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CarManager : MonoBehaviour
{
    public tilesetController tileScript;
    public float speed;
    int i = 0;
    bool start = false;
    List<Transform> points;

    
    void Start()
    {
        tileScript = GameObject.Find("Main Camera").GetComponent<tilesetController>();
        //Vector2.Lerp(gameObject.transform.position, tileScript.points[0].transform.position, speed);
    }
    
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tileScript.points.Count; i++)
        {
            if (Vector2.Distance(gameObject.transform.position, tileScript.points[i].transform.position) <= 0.2f)
            {
                tileScript.points.Remove(tileScript.points[i]);

            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            start = true;
        }
        if (start)
        {
            
            
            transform.position = Vector2.MoveTowards(gameObject.transform.position, GetClosestPoint(tileScript.points).position, speed * Time.deltaTime);

            
            
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
            if (dist < minDist && minDist > 1)
            {
                tMin = t.transform;
                minDist = dist;
               
            }
            
        }
        
        Debug.Log(tMin);
        return tMin;
    }
    private void FixedUpdate()
    {
        

    }
}
