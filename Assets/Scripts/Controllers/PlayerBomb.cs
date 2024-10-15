using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class PlayerBomb : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public GameObject thatIsEnemy;
    public float theAddSpeed;
    
    // Update is called once per frame
    void Update()
    {
        
        float theSpeed = theAddSpeed / speed;
        float Speed = theSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, thatIsEnemy.transform.position, Speed);

    }
}
