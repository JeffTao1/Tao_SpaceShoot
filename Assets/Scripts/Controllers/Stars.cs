using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime;

    // Update is called once per frame
    void Update()
    {
        DrawConstellation(starTransforms);
    }
    public void DrawConstellation(List<Transform> NextStar)
    {
        foreach (Transform starTransforms in NextStar)
        {

            Debug.DrawLine(transform.position, starTransforms.position, Color.green, drawingTime);

        }
    }
}
