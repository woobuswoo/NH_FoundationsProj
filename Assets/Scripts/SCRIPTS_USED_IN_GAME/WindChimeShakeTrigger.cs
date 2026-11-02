using UnityEngine;

public class WindChimeShakeTrigger : MonoBehaviour
{
    public Animator ObjAnimator;

    public void WindChimeShakeAnimation()
    {
        if(ObjAnimator != null)
        {
            ObjAnimator.SetTrigger("ShakeTrigger");
        }
    }
    
}
