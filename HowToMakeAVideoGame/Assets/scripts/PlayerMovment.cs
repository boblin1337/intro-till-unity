using UnityEngine;

public class PlayerMovment : MonoBehaviour
{   // 
    public Rigidbody rb;



    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "Fixed"Update becuse we
    // are using it to mess with physics.
    void FixedUpdate()
    {

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
