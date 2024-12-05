using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerjeff : MonoBehaviour
{
    [SerializeField] float speed;
    float gowherex;
    float gowherey;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField]float dash;
    
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
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-transform.localScale.x * dash, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(transform.localScale.x * dash, 0);

        }


        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(0, transform.localScale.y * dash);
        }


        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(0, -transform.localScale.y * dash);

        }

    }
    
}
