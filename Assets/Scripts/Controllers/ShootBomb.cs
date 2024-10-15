using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBomb : MonoBehaviour
{
    public float speed;
    public GameObject EnemyShootPoint;
    float timeRotate = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position += transform.up * speed * Time.deltaTime; //new Vector3(0,EnemyShootPoint.transform.position.y  +  speed * Time.deltaTime,0);
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //transform.rotation = Quaternion.Euler(0, 0, 45);
           
             transform.Rotate(0, 0, 1f + timeRotate*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            //transform.rotation = Quaternion.Euler(0, 0, -45);
            transform.Rotate(0, 0, -1f + timeRotate * Time.deltaTime);
        }
    }


    
}
