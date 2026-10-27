using UnityEngine;

public class FallingAnimTrigger : MonoBehaviour
{
    public Animator ObjAnimator;
     //This script is made for an Animation Event function. That once the animation hits the event, it stars whatever function is attached to the object.
    public void FallingAnimation()
    //this says if the ObjAnimator IS NOT empty, to trigger the FallTrigger parameter that is within that objects animator. Since the Animation Event is at the end of the bin's shake animation, it triggers once it reaches the end, allowing the can to begin its fall animation.
    {
        if(ObjAnimator != null)
        {
            ObjAnimator.SetTrigger("FallTrigger");
        }
    }
}
