using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLegLeft : MonoBehaviour
{
    Rigidbody2D myBody;

    float legPower = 10f;

    Vector3 leftLegMove = new Vector3(-1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if i press the W key
        if (Input.GetKeyDown(KeyCode.W))
        {
            myBody.AddForce(leftLegMove * legPower, ForceMode2D.Impulse);
        }
    }
}
