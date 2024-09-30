using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    public float MaxSpeed = 10f;
    public float timeToMaxSpeed = 3f;
    float acceleration = 2f;

    Vector3 velocity;

    void Update()
    {
        
        
        acceleration = MaxSpeed / timeToMaxSpeed;//acceleration means how far am i accetermting
        float Change = acceleration * Time.deltaTime;
        // PlayerMovement();
        // Vector3 velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity += Vector3.left * Change;
            

        }
        else
        {
            velocity += Vector3.right * Change;
            transform.position = velocity;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            velocity += Vector3.right * Change;
           

        }
        else
        {
            velocity += Vector3.left * Change;
            transform.position = velocity;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
           
            velocity += Vector3.up * Change;
            
        }
        else
        {
            velocity += Vector3.down * Change;
            transform.position = velocity;
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            velocity += Vector3.down * Change;
           
        }
        else
        {
            velocity += Vector3.up * Change;
            transform.position = velocity;
        }

        //if (Input.GetKeyUp(KeyCode.LeftArrow) )
        //{

        //    transform.position = new Vector3(transform.position.x * new Vector3(, transform.position.y);


        //}





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

    public void EnemyRadar(float radius, int circlePoint)
    {
    
    }

}
