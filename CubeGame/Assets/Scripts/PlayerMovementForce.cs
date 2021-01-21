using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementForce : MonoBehaviour
{

    public Rigidbody rb;
    public float forceForward = 10f;
    public float forceSide = 1f;
    float horizontal;
    
    


    void Start()
    {
       
    }

    void FixedUpdate() // jesli uzywamy fizyki, dobrą praktyką jest pisanie w FixedUpdate zamiast Update. Poprawia to wydajność
    {

        rb.AddForce(forceForward * Time.unscaledDeltaTime, 0f, 0f);
        horizontal = Input.GetAxis("Horizontal");


        /*   Sterowanie ze średnią bezwładnością
        if (Input.GetKey(KeyCode.A))
		{
            rb.AddForce(0f, 0f, forceSide * Time.deltaTime, ForceMode.VelocityChange);
		}

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0f, 0f, -forceSide * Time.deltaTime, ForceMode.VelocityChange);
        }
        */
      //  rb.AddForce(0f, 0f, -forceSide * Time.deltaTime*horizontal, ForceMode.VelocityChange);    // Sterowanie z dużą bezwładnością

       transform.position += new Vector3(0f, 0f, -horizontal * forceSide * Time.deltaTime);    // Sterowanie bez bezwładności, za to z lekkim nabudowywaniem prędkości horyzontalnej
        
    }
}
