using UnityEngine;

public class Jump_gravity : MonoBehaviour
{
    //This script is used to add a jump force to the player when space is pressed. The public float jumpAmount allows me to change the amount of force applied.
    public Rigidbody rb;
    public float jumpAmount;
    private bool isJumping;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            isJumping = true;
        }
        
    }
//This function is used to stop the player from spamming space to stay in the air. The OnCollisionEnter function checks to see when the player collides with the ground and sets isJumping to false, allowing the player to jump again.
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
