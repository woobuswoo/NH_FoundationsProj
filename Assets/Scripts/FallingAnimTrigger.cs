using UnityEngine;

public class FallingAnimTrigger : MonoBehaviour
{
    public Animator ObjController;
    
    public void FallingAnimation()
    
    {
        if(ObjController != null)
        {
            ObjController.SetTrigger("FallTrigger");
        }
    }
}
