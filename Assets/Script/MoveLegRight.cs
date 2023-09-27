using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLegRight : MonoBehaviour
{
    Rigidbody2D myBody;

    float legPower = 10f;

    Vector3 rightLegMove = new Vector3(-1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if i press the S key
        if (Input.GetKeyDown(KeyCode.S))
        {
            myBody.AddForce(rightLegMove * legPower, ForceMode2D.Impulse);
        }
    }
}
