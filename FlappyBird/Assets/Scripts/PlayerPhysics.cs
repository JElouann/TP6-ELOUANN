using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    [Header("Gameplay")]
    [SerializeField]
    private float _jumpForce;
    [SerializeField]
    private GameObject _score;
    private Vector3 jumpForce;
    private Rigidbody _rb;
    [SerializeField]
    private bool _isReversed;

    [Header("Feedback")]
    [SerializeField]
    private SoundManager _soundManager;
    [SerializeField]
    private AudioClip _audioClip;

    public void ReverseGravity()
    {
        if (this._isReversed)
        {
            Physics.gravity = new Vector3(Physics.gravity.x, Physics.gravity.y * -1, Physics.gravity.z);
            this.jumpForce *= -1;
        }
    }

    private void Start()
    {
        this._rb = this.GetComponent<Rigidbody>();
        this.jumpForce = new Vector3(0, this._jumpForce, 0);
        this.ReverseGravity();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this._soundManager.PlaySound(this._audioClip);
            this._rb.AddForce(this._rb.transform.forward + this.jumpForce, ForceMode.Impulse);
            this._rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
