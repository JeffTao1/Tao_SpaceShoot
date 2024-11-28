using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class round : MonoBehaviour
{
    public GameObject attack;
    Vector3 mousewhere;
    // Start is called before the first frame update
    void Start()
    {
       mousewhere = attack.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mousewhere = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        

        Vector3 where = mousewhere - transform.position; 

        float mouseangle = Mathf.Atan2(where.y, where.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, mouseangle);
    }
}
