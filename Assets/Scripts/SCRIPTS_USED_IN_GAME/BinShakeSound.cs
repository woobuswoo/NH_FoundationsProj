using UnityEngine;

public class BinShakeSound : MonoBehaviour
{
  [SerializeField] private AudioClip binShakeSound;
  [SerializeField] private AudioSource audioSource;

  public void PlayBinShakeSound()
    {
        audioSource.PlayOneShot(binShakeSound);
    }
}
