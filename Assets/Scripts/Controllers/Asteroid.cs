using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed = 2;
    public float arrivalDistance = 1;
    public float maxFloatDistance =10;
    Vector3 whereTheirRandom;
    // Start is called before the first frame update
    void Start()
    {
        AsteroidMovement();
    }

    // Update is called once per frame
    void Update()
    {
        AsteroidMovement();
    }
    public void AsteroidMovement()
    {
        whereTheirRandom = transform.position + new Vector3( Random.Range(maxFloatDistance, -maxFloatDistance), Random.Range(-maxFloatDistance, -maxFloatDistance), 0);
        transform.rotation = Random.rotation;
    }
}
