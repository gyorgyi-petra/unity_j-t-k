using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    public float BunnySpeed = 0;
    public float BunnyRotate;
    public Transform Bunny;
    private float f = 0.0f;

	void Start () {
		
	}
	
	void FixedUpdate () {
        Bunny.Translate(Vector3.up * BunnySpeed * Time.deltaTime * 2f);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Bunny.transform.Rotate(Vector3.back * BunnyRotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Bunny.transform.Rotate(Vector3.forward * BunnyRotate * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            if (BunnySpeed >= 0)
            {
                if (BunnySpeed < 20)
                {
                    BunnySpeed++;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (BunnySpeed >= 0)
            {
                if (BunnySpeed <= 20 && BunnySpeed != 0)
                {
                    BunnySpeed--;
                }
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            BunnySpeed = 0;
        }
    }
    public void nullspeed()
    {
        BunnySpeed = 0;
    }
}
