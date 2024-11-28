using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootyellow : MonoBehaviour
{
    public GameObject bolit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.O))
        {
            GameObject shootObject = Instantiate(bolit, transform.position, transform.rotation);
        }
    }
}
