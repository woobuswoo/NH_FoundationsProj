using UnityEngine;

public class Jump_gravity : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpAmount;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
        
    }
}
