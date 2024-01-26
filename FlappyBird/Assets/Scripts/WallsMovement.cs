using System.Collections;
using System.Collections.Generic;
using UnityEditor.Overlays;
using UnityEngine;

public class WallsTravel : MonoBehaviour
{

    [SerializeField]
    private float Speed;

    private Rigidbody rb;
    private GameObject wall;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Speed, 0, 0);
        wall = GetComponent<GameObject>();
        StartCoroutine(Destroy());
    }

    void Update()
    {

    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2.5f);
        //Debug.Log("Le mur doit être détruit");
        Destroy(gameObject);
    }
}
