using UnityEngine;

public class WindChimeShakeTrigger : MonoBehaviour
{
    public Animator ObjAnimator;

//same as the fallanimTrigger script, but also plays a sound within the soundmanger script!
    public void WindChimeShakeAnimation()
    {
        if(ObjAnimator != null)
        {
            ObjAnimator.SetTrigger("ShakeTrigger");
        }

        SoundManager.Instance.PlayChimesHitSound();
    }
    
}
