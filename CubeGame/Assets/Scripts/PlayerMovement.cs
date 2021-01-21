using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform playerPos;
    public float playerSpeed = 1f;
    public float playerAgitity = 2f;
    float horizontal;

    void Start()
    {
        
    }

   
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(playerSpeed * Time.deltaTime, 0f, -horizontal * playerAgitity * Time.deltaTime);

       
    }
}
