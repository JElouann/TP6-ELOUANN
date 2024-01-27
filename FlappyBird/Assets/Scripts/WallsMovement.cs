using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Overlays;
using UnityEngine;

public class WallsTravel : MonoBehaviour
{

    [SerializeField]
    private float Speed;

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Speed, 0, 0);

        StartCoroutine(Destroy());
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1.9f);
        Destroy(gameObject);
    }
}
