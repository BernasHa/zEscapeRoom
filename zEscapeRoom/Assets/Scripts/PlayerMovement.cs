using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController player;
    public Transform groundCheck;
    public LayerMask groundMask;

    public float speed = 10f;
    public float jumpHeight = 10;
    public float gravity = -10f;

    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        //Jumping
        if(isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Check if we collide with the Ground
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f , groundMask);

        //moving the Player on X and Z
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moving = x * transform.right + z * transform.forward;

        player.Move(moving * speed * Time.deltaTime);

        //Gravity when we fall from a higher Spot
        velocity.y += gravity * Time.deltaTime;
        player.Move(velocity * Time.deltaTime);
    }
    
}
