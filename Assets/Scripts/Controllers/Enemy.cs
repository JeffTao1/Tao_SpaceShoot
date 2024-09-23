using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public GameObject theBomb; 
    float speed = 10f;
    int MaxBomb;
    float lifeTime = 3f;
    private void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0,0,-90);
        }


        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
           
            transform.rotation = Quaternion.Euler(0, 0, -45);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {

            transform.rotation = Quaternion.Euler(0, 0, 135);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {

            transform.rotation = Quaternion.Euler(0, 0, -135);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject howMuchBomb =  Instantiate(theBomb, transform.position,transform.rotation);
            Destroy(howMuchBomb,lifeTime);
        }





    }

}
