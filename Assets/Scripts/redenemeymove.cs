using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redenemeymove : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y );
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y );
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
      
    }
}
