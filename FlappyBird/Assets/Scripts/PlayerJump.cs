using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float JumpForce;

    [SerializeField]
    private GameObject Score;

    private Vector3 _jumpForce;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _jumpForce = new Vector3(0,JumpForce ,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Space");
            rb.AddForce(rb.transform.forward + _jumpForce, ForceMode.Impulse);
            rb.velocity = new Vector3(0,0,0);
        }
    }
}
