using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity;
    public Vector3 deltaMove;
    public float speed;
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
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        player.transform.Translate(deltaMove);

    }
}    

