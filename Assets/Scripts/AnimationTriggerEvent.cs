using UnityEngine;

public class AnimationTriggerEvent : MonoBehaviour
{
    public Animator fallingObjectAnimator;

    public void TriggerFallAnimation()
    {
        if(fallingObjectAnimator !=null)
        {
            fallingObjectAnimator.SetTrigger("FallTrigger");
        }
    }
}
