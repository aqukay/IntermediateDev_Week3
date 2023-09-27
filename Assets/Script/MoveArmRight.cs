using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArmRight : MonoBehaviour
{
    Rigidbody2D myBody;

    float armPower = 5f;

    Vector3 rightArmMove = new Vector3(1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if i press D key
        if (Input.GetKeyDown(KeyCode.D))
        {
            myBody.AddForce(rightArmMove * armPower, ForceMode2D.Impulse);
        }
    }
}
