using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundary : MonoBehaviour
{
    private float topBoundary = 40f;
    private float lowerBoundary = -10f;
    private float sideBoundery = 33f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBoundary)
        {
            Destroy(gameObject);
        } else if (transform.position.x > sideBoundery)
        {
            Destroy(gameObject);
        } else if (transform.position.x < -sideBoundery)
        {
            Destroy(gameObject);
        }
    }
}
