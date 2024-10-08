using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeVsion : MonoBehaviour
{
    public GameObject TARGET;
    public float sightDistance;
    public float visionAngle;


    // Update is called once per frame
    void Update()
    {
        float angleInRads = visionAngle * Mathf.Deg2Rad;

        Vector3 LeftVector = new Vector3(Mathf.Cos(angleInRads), Mathf.Sin(angleInRads), 0) * sightDistance;
        Vector3 RightVector = new Vector3(Mathf.Cos(-angleInRads), Mathf.Sin(-angleInRads), 0) * sightDistance;

        Debug.DrawLine(transform.position, transform.position + LeftVector, Color.black);
        Debug.DrawLine(transform.position, transform.position + RightVector, Color.black);





        DrawVisionCone();
        if(TARGET != null)
        {
            Vector3 vectorToTarget = TARGET.transform.position - transform.position;

            Debug.DrawLine(transform.position, transform.position + vectorToTarget, Color.green);

            float dotProduct = Vector3.Dot(transform.right, vectorToTarget.normalized);
            float dontProduct = Vector3.Dot(transform.right, LeftVector.normalized);

            if (dotProduct >= dontProduct && vectorToTarget.magnitude <= sightDistance)
            {
                print("hi");
            }
        }
       
    }
    private void DrawVisionCone()
    {

    }
}
