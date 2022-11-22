using UnityEngine;

public class PlayerMovment : MonoBehaviour
{   // 
    public Rigidbody rb;

    
    // We marked this as "Fixed"Update becuse we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // Add force of 2000 on the z-axis
    }
}
