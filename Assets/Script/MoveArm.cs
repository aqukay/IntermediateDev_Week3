using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm : MonoBehaviour
{
    Rigidbody2D myBody;

    float armPower = 5f;

    Vector3 leftArmMove = new Vector3(-1, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if i press the A key
        if (Input.GetKeyDown(KeyCode.A))
        {
            myBody.AddForce(leftArmMove * armPower, ForceMode2D.Impulse);
        }
    }
}