using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBomb : MonoBehaviour
{
    public float speed;
    public GameObject EnemyShootPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(0,EnemyShootPoint.transform.position.y  +  speed * Time.deltaTime,0);
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(0, 0, -45);

        }
    }
}
