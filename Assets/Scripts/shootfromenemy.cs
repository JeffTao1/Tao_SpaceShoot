using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootfromenemy : MonoBehaviour
{
    public GameObject bolit;

    // Start is called before the first frame update
 
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            GameObject shootObject = Instantiate(bolit, transform.position, transform.rotation);
        }
            
       
      
        
    }
}
