using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsMove : MonoBehaviour
{
    [SerializeField]float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.65f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
