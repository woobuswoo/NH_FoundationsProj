using System;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    //SCRIPT MADE FROM DAVE/GAMEDEVELOPMENT TUTORIAL ON YOUTUBE
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private void Start()
    {
        //this keeps the mouse locked to the camera and hides the visibilty of the mouse.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //mouse input where the mouse is on screen.
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        // stop rotation from going too high or low
        xRotation = Math.Clamp(xRotation, -90f, 90f);
        
        //this is used to calculate the rotation and orientation of the camera and player, within the hierarchy there is an empty object called orientation, this stores the direction of where the player is facing.

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
