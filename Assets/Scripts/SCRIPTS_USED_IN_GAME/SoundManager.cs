using UnityEngine;

public class SoundManager : MonoBehaviour
{
  [SerializeField] private AudioClip collectSound;
  [SerializeField] private AudioClip jumpSound;
  [SerializeField] private AudioClip chimesHitSound;
  [SerializeField] private AudioSource audioSource;
  [SerializeField] private AudioClip binShakeSound;

  public static SoundManager Instance;

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
