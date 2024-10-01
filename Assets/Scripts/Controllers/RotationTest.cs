using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTest : MonoBehaviour
{
    public float AngularSpeed=45;
    public float TargetAngle = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawLine(new Vector3(transform.position.x,0, 0),transform.position,Color.black);
        //if(transform.rotation.z == TargetAngle)
        //{
        //    transform.Rotate(0, 0, 0);
        //}
        //else
        //{
        //    transform.Rotate(0, 0, AngularSpeed * Time.deltaTime);
        //}
        Debug.DrawLine(transform.position,transform.position + transform.up,Color.blue);

        float currentRotation = transform.rotation.eulerAngles.z +90; //* Mathf.Rad2Deg;

        if (TargetAngle - currentRotation <0)
        {
            if (currentRotation > TargetAngle)
            {
                transform.Rotate(0, 0,- AngularSpeed * Time.deltaTime);
            }
        }
        else
        {
            if (currentRotation < TargetAngle)
            {
                transform.Rotate(0, 0, AngularSpeed * Time.deltaTime);
            }
        }

        //if (currentRotation +90 < TargetAngle)
        //{
        //    transform.Rotate(0, 0, AngularSpeed * Time.deltaTime);
        //}
        Debug.Log($"<color=blue><size=18>{currentRotation}</size></color>");
    }
    public float StandardizeAngle(float inAngle)
    {
        inAngle %= 360;

        if(inAngle > 180)
        {
            inAngle -= 360;
        }
        return inAngle;
    }
}
