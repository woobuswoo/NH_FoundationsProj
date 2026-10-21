using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //SCRIPT MADE FOLLOWING DAVE/GAMEDEVELOPMENT ON YOUTUBES TUTORIAL
    public float moveSpeed;

//The Transform orientation helps to dictate whichever direction is forward and right for the player, ensuring whenever W is pressed it will follow the camera direction/orientation.
    public Transform orientation;

// horizontalInput and verticalInput store the keyboard input, horizontal is A/D and vertical W/S
    float horizontalInput;
    float verticalInput;

// Vector3 moveDirection is whatever 3D vector that has this script will calculate the direction the player moves
    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        
    }

//this will update with whatever is in the MyInput method
    private void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        //Reading the keyboard (W/A/S/D) for and instant calculation
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

    }

    private void MovePlayer()
    {
        //This calculates if you are pressing W its equal to the direction of the camera is facing, or if you press S it points it the opposite. 
        // moecDirection.normalized helps with diagonal direction, keeping it from moving faster diagonally than straight forward and diagnoal vetors are longer than straight.
        moveDirection = orientation.forward *verticalInput + orientation.right * horizontalInput;

        //ForceMode.Force applies a continuous force keeping it smooth than a burst of speed.

        rb.AddForce(moveDirection.normalized * moveSpeed * 5f, ForceMode.Force);
    }
}
