using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boommovement : MonoBehaviour
{
    float speed = 3f;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
 
         Destroy(gameObject,15);
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameObject.CompareTag("r"))
        {
            //Destroy(gameObject);
            // GameObject totalbomb = Instantiate(gameObject, transform.position, Quaternion.identity);
            //totalbomb.transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);

            GetComponent<Rigidbody2D>().AddForce(transform.up * speed, ForceMode2D.Impulse);//energy to shoot




        }
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("y"))
            {
                Destroy(collision.gameObject);
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
