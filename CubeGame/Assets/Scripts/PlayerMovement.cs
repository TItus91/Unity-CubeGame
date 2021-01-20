using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forceForward = 10f;
    public float forceSide = 1f;

    
    


    void Start()
    {
       
    }

    void FixedUpdate() // jesli uzywamy fizyki, dobrą praktyką jest pisanie w FixedUpdate zamiast Update. Poprawia to wydajność
    {

        rb.AddForce(forceForward, 0f, 0f);

        if (Input.GetKey(KeyCode.A))
		{
            rb.AddForce(0f, 0f, forceSide,ForceMode.VelocityChange);
		}

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0f, 0f, -forceSide, ForceMode.VelocityChange);
        }
    }
}
