using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_collision : MonoBehaviour
{
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with" + collision.gameObject.name);

        //trigger dialogue box
        if (collision.gameObject.name == "distance marker")
        {
            Camera.main.transform.Translate(10, 0, 0);
        }

        if (collision.gameObject.name == "finish line")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
