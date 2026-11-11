using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //This script is used on the CameraHolder object. This is to stop the camera from being buggy and glitchy when parented to the player directly. 
    //This script ensure the camera is always following the player as it links to the empty object called camera posistion thats within the players hierarchy.
   public Transform cameraPosition;

   private void Update()
    {
        transform.position = cameraPosition.position;
    }
}
