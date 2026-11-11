using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity;
    public GameObject player;
    
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked; 
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        player.transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        

    

    }
}    

