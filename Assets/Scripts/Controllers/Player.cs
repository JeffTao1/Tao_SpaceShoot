using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;
    public float speed = 10;
    void Update()
    {
       // PlayerMovement();
        Vector3 offset = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
            offset += Vector3.left * speed;

        if (Input.GetKey(KeyCode.RightArrow))
            offset += Vector3.right * speed;

        if (Input.GetKey(KeyCode.UpArrow))
            offset += Vector3.up * speed;

        if (Input.GetKey(KeyCode.DownArrow))
            offset += Vector3.down * speed;

        PlayerMovement(offset);
    }
    public void PlayerMovement(Vector3 offset)
    {



        transform.position += offset * Time.deltaTime;
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
