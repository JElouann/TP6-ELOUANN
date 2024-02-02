using UnityEditor;
using UnityEngine;

public class Death : MonoBehaviour
{
    [Header("UI")]
    [SerializeField]
    private GameObject _score;
    [Header("Feedbacks")]
    [SerializeField]
    private SoundManager _soundManager;
    [SerializeField]
    private AudioClip _audioClip;
    [SerializeField]
    private CameraShake _cameraShake;

    public void End()
    {
        // _score.SendMessage("PrintEndScore");
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        this._soundManager.PlaySound(this._audioClip);
        this.StartCoroutine(this._cameraShake.Shake());
    }
}
