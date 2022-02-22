using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardForce = 2000f;
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float PlayerSpeed = 500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Fixed-update is called once physics refresh
    void FixedUpdate()
    {
        // ADD a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * PlayerSpeed, 0, 0);
        }
         if ( Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * PlayerSpeed, 0, 0);
        }
         if ( Input.GetKey("w") )
        {
            rb.AddForce(0, 0, sidewaysForce * PlayerSpeed);
        }
         if ( Input.GetKey("s") )
        {
            rb.AddForce(0, 0, -sidewaysForce * PlayerSpeed);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
