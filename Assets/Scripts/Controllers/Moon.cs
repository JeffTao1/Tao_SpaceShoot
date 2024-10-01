using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Moon : MonoBehaviour
{
    public Transform planetTransform;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        OrbitalMotion(2,1,planetTransform);
    }
    public void OrbitalMotion(float radius, float speed, Transform target)
    {

        float Angle = speed*Time.deltaTime*Mathf.Deg2Rad;

        transform.position = new Vector3(Mathf.Cos(Angle) * radius, Mathf.Sin(Angle) * radius, Mathf.Tan(Angle) * radius) +target.position;
       
    }



}
