using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertheone : MonoBehaviour
{
    public float speed;
    public float staytime;
    public GameObject Bomb;
    public GameObject SDBomb;
    float checktime;
    bool isTheTimerStart = false;
    public GameObject whereshoot;
    float radius;
    public GameObject enemywhere;
    public float newchecktime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            transform.rotation = Quaternion.Euler(0, 0, -90);
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

        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.D))
        {

            transform.rotation = Quaternion.Euler(0, 0, -135);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            GameObject THEbOMB = Instantiate(Bomb, whereshoot.transform.position, transform.rotation);
            THEbOMB.GetComponent<PlayerBomb>().thatIsEnemy = enemywhere;

            checktime = 0f;
            isTheTimerStart = true;
            Destroy(THEbOMB, staytime);

        }


        if (isTheTimerStart)
        {
            checktime += Time.deltaTime;
        }

        if (checktime >= staytime)
        {
            float anglewhere = 360f / 5f;
            for (int i = 0; i < 5f; i++)
            {
                float angle = i * anglewhere * Mathf.Deg2Rad;
                Vector3 whereBOMB = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);
                GameObject totalbomb = Instantiate(SDBomb, this.Bomb.transform.position, Quaternion.identity);
                Destroy(totalbomb, staytime);
                newchecktime += Time.deltaTime;
                if (newchecktime >= 0.2f)
                {
                    return;
                }
            }
            isTheTimerStart = false;

        }
        
    }
}



