using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxScript : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float dist = cam.transform.position.x * parallaxEffect;
        float temp = cam.transform.position.x * (1 - parallaxEffect);
       
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
     
        if (temp > startpos + length) 
           startpos += length;
              else if (temp < startpos - length)
                      startpos -= length;

    }
}
