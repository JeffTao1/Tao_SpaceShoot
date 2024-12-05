using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescreen : MonoBehaviour
{

       
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        SceneManager.LoadSceneAsync(1);
       
    }
}
