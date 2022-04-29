using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsController : MonoBehaviour
{
    public GameObject[] clouds;
    private float nextActionTime = 0.0f;
    public float period = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime ) 
        {
            nextActionTime += period;
             // execute block of code here
            Vector3 spawnPos = new Vector3(Random.Range(15f,20f),Random.Range(-6f,6f),0);
            Instantiate(clouds[Random.Range(0,6)],spawnPos,Quaternion.identity);
            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        if (other.tag == "cloud")
        {
            Debug.Log("geçtii");
        }
    }
}
