using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    [Header("Gameplay")]
    [SerializeField]
    private float JumpForce;
    [SerializeField]
    private GameObject Score;
    private Vector3 _jumpForce;
    Rigidbody rb;
    [SerializeField]
    private bool IsReversed;

    [Header("Feedback")]
    [SerializeField]
    private SoundManager SoundManager;
    [SerializeField]
    private AudioClip AudioClip;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        _jumpForce = new Vector3(0,JumpForce ,0);
        ReverseGravity();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Space");
            SoundManager.PlaySound(AudioClip);
            rb.AddForce(rb.transform.forward + _jumpForce, ForceMode.Impulse);
            rb.velocity = new Vector3(0,0,0);
        }
    }

    public void ReverseGravity() //
    {
        if (IsReversed)
        {
            Physics.gravity = new Vector3(Physics.gravity.x, Physics.gravity.y * -1, Physics.gravity.z);
            _jumpForce *= -1;
        }
    }
}
