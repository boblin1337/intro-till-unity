using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Här är min playermovment klass. Detta gör så att jag kan röra min spelare åt alla håll.
/// Samt en groundcheck så håller koll på marken man är på.
/// Även fixar så det finns gravity så man åker neråt.
/// </summary>

public class PlayerMovment : MonoBehaviour
{


    public Lava slutet;

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public LayerMask endMask;
    public bool start;
    

    Vector3 velocity;
    bool isGrounded;
    bool endGrounded;

    // Update is called once per frame
    void Update()
    {

        endGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, endMask);
        if (endGrounded)
        {
            start = false;

            slutet.end();
            
        }





        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded)
        {
            start = true;
        }


        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -10f;
        }


        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * X + transform.forward * Z;

        controller.Move(move * speed * Time.deltaTime);

       velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        


        rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
    }
    
    


}
