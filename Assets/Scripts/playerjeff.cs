using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerjeff : MonoBehaviour
{
    [SerializeField] float speed;
    float gowherex;
    float gowherey;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       gowherex = Input.GetAxis("Horizontal");
       gowherey = Input.GetAxis("Vertical");

       transform.Translate(gowherex * speed * Time.deltaTime, 0, 0);
       transform.Translate(0, gowherey * speed * Time.deltaTime, 0);
       
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.tag = "y";
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gameObject.tag = "Player";
        }
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.tag = "r";
        }
        else if (Input.GetMouseButtonUp(1))
        {
            gameObject.tag = "Player";
        }

    }
}
