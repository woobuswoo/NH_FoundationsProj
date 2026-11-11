using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //This script is to store all sounds ued within the game. Its used as a sort of holder of what audios to play within other scripts.
    //Like the jump for example, The script says to find and play whatever audio source is within the field jumpsound. In my jump script i have a piece of code that then references this manager and the specific method for the jump sound.

  [SerializeField] private AudioClip collectSound;
  [SerializeField] private AudioClip jumpSound;
  [SerializeField] private AudioClip chimesHitSound;
  [SerializeField] private AudioSource audioSource;
  [SerializeField] private AudioClip binShakeSound;

  //To be able to reference this script I have to make the script a singleton/instance.

  public static SoundManager Instance;

  //This basically says, that if the sound manager doesnt exist, then to create one but if it does already exist then to destroy the instance that unity is trying to create. But to also not destroy the soundmanager when restarting/reloading the game.

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectSound);

    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void PlayChimesHitSound()
    {
        audioSource.PlayOneShot(chimesHitSound);
    }

    public void PlayBinShakeSound()
    {
        audioSource.PlayOneShot(binShakeSound);
    }
}
