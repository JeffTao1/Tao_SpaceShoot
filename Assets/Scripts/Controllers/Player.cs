using Codice.CM.Common;
using System;
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
    public GameObject powerUp;

    Vector3 velocity;
    Color color;

    public float radius = 5f;
    public int points = 5;

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



        SpawnPowerups(3, 5);

        PlayerMovement();
        EnemyRadar(radius, points);
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

    public void EnemyRadar(float radius, int circlePoint=5)
    {
        Vector3 start = new Vector3(radius, 0, 0);
        Vector3 next = start;
        float whereIsEnemy = Vector3.Distance(transform.position,enemyTransform.position);
        
        for (int i = 0; i < circlePoint; i++)
        {
            float theAngle = 2f * Mathf.PI / (float)circlePoint * i;
            Vector3 whereTheCircle = transform.position = new Vector3(Mathf.Cos(theAngle) * radius, Mathf.Sin(theAngle) * radius,0);
            next = whereTheCircle;
        }
        if(whereIsEnemy<=radius)
        {
            color = Color.red;
        }
        else
        {
            color = Color.green;
        }
        
        Debug.DrawLine(start,next,color);
    }
    public void SpawnPowerups(float radius, int numberOfPowerups)
    {
        for(int i = 0;i < numberOfPowerups;i++)
        {
            float angle = 360f / numberOfPowerups;
            Vector3 whereItSpawn = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);

            Instantiate(powerUp, whereItSpawn * Mathf.Deg2Rad, Quaternion.identity);
        }


       
    }
}
