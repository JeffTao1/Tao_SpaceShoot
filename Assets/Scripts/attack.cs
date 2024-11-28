using Codice.Client.BaseCommands;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    
    //public Collider2D c2d;


    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gameObject.tag = "y";
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gameObject.tag = "Player";
        }
        if (Input.GetMouseButton(1))
        {
            gameObject.tag = "r";
        }
        else if (Input.GetMouseButtonUp(1))
        {
            gameObject.tag = "Player";
        }
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        c2d.isTrigger = true;
    //    }
    //    if (Input.GetKeyUp(KeyCode.Space))
    //    {
    //        c2d.isTrigger = false;
    //    }

    }







    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Destroy(collision.gameObject);
    //}





}
