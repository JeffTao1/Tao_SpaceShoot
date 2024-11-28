using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class yellowboommovement : MonoBehaviour
{
    float speed = 3f;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y );

        Destroy(gameObject, 15);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("y"))
        {
            //Destroy(gameObject);
            // GameObject totalbomb = Instantiate(gameObject, transform.position, Quaternion.identity);
            //totalbomb.transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            
            
                rb.AddForce(transform.up * speed, ForceMode2D.Impulse);//energy to shoot

             

            
        }
        else if ((!collision.gameObject.CompareTag("Player") || !collision.gameObject.CompareTag("r")))
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
