using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public GameObject theBomb;
    public GameObject shootPoint;
    public GameObject wheretheEnemyat;
    float speed = 10f;
    int MaxBomb;
    float lifeTime = 3f;
    private void Update()
    {

        wheretheEnemyat.transform.position = transform.position;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
            transform.rotation = Quaternion.Euler(0,0,-90);
        }


        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
           
            transform.rotation = Quaternion.Euler(0, 0, -45);
        }

        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {

            transform.rotation = Quaternion.Euler(0, 0, 135);
        }

        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {

            transform.rotation = Quaternion.Euler(0, 0, -135);
        }



        if (Input.GetKeyDown(KeyCode.Mouse2))
        {

            GameObject howMuchBomb = Instantiate(theBomb , shootPoint.transform.position , transform.rotation);
            Destroy(howMuchBomb, lifeTime);

            //ShootBomb sb = howMuchBomb.GetComponent<ShootBomb>();
            //sb.EnemyShootPoint = shootPoint;
        }



    }

}
