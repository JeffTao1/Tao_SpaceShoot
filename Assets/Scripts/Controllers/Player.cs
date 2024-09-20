using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    public float MaxSpeed = 20f;
    public float timeToMaxSpeed = 3f;
    bool IsTheTime = false;
    
    Vector3 velocity;

    void Update()
    {

        
        float acceleration = MaxSpeed / timeToMaxSpeed;//acceleration means how far am i accetermting
        float Change = acceleration * Time.deltaTime;
        // PlayerMovement();
        // Vector3 velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
            velocity += Vector3.left * Change ;

        if (Input.GetKey(KeyCode.RightArrow))
            velocity += Vector3.right * Change;

        if (Input.GetKey(KeyCode.UpArrow))
            velocity += Vector3.up * Change;

        if (Input.GetKey(KeyCode.DownArrow))
            velocity += Vector3.down * Change;



        PlayerMovement();

    }
    public void PlayerMovement()
    {



        transform.position += velocity *  Time.deltaTime;
      
        



        //if (Input.GetKey(KeyCode.UpArrow))
        //{

        //    transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{

        //    transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{

        //    transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{

        //    transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
        //}

    }

}
