using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArm : MonoBehaviour
{
    public Rigidbody2D myBody;
    SoundManager mySoundManager;

    float power = 200f;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        mySoundManager = GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            mySoundManager.myAudioSource.PlayOneShot(mySoundManager.armSound);
            myBody.AddForce(transform.up * power, ForceMode2D.Impulse);
        }
    }
}
