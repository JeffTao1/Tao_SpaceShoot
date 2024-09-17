using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;
    public float speed = 1;
    void Update()
    {
       // PlayerMovement();
        Vector3 offset = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
            offset += Vector3.left * 0.01f;

        if (Input.GetKey(KeyCode.RightArrow))
            offset += Vector3.right * 0.01f;

        if (Input.GetKey(KeyCode.UpArrow))
            offset += Vector3.up * 0.01f;

        if (Input.GetKey(KeyCode.DownArrow))
            offset += Vector3.down * 0.01f;

        PlayerMovement(offset);
    }
    public void PlayerMovement(Vector3 offset)
    {



        transform.position += offset;
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
