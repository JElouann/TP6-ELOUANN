using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;

    public void PlaySound(AudioClip audioClip)
    {
        this._audioSource.PlayOneShot(audioClip);
    }
}
