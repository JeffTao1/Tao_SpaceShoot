using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redandblue : MonoBehaviour
{
    public float redAngle;
    public float blueAngle;


    // Update is called once per frame
    void Update()
    {
        float redReds = redAngle * Mathf.Deg2Rad;
        float blueBlue = blueAngle * Mathf.Deg2Rad;

        Vector3 redVector = new Vector3(Mathf.Cos(redAngle), Mathf.Sin(redAngle), 0);
        Vector3 blueVector = new Vector3(Mathf.Cos(blueAngle), Mathf.Sin(blueAngle), 0);

        Debug.DrawLine(Vector3.zero, redVector, Color.red);
        Debug.DrawLine(Vector3.zero, blueVector, Color.blue);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            double dotProduct = (double)(redVector.x * blueVector.x) + (double)(redVector.y * blueVector.y);
            //if (Mathf.Abs(dotProduct) < float.Epsilon) dotProduct = 0;

            print(dotProduct);
        }
       
    }
}
