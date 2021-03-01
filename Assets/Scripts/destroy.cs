using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private float outOfBounds = 30f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > outOfBounds)
            Destroy(gameObject);
        else if (transform.position.z < -outOfBounds)
            Destroy(gameObject);
    }
}
