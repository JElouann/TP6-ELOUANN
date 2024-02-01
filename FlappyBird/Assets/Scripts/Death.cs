using UnityEditor;
using UnityEngine;

public class Death : MonoBehaviour
{
    [Header("UI")]
    [SerializeField]
    private GameObject Score;
    [Header("Feedbacks")]
    [SerializeField]
    private float _cameraShakeDuration;
    [SerializeField]
    private float _cameraShakeMagnitude;
    [SerializeField]
    private SoundManager _soundManager;
    [SerializeField]
    private AudioClip _audioClip;
    public CameraShake CameraShake;

    private void OnCollisionEnter(Collision collision)
    {
        _soundManager.PlaySound(_audioClip);
        StartCoroutine(CameraShake.Shake(_cameraShakeDuration, _cameraShakeMagnitude));
    }

    public void End()
    {
        Score.SendMessage("PrintEndScore");
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
