using System.Collections;
using UnityEngine;

public class WallsMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rb;

    public void StopMove()
    {
        this._rb.velocity = Vector3.zero;
    }

    private void Start()
    {
        this._rb = this.GetComponent<Rigidbody>();
        this._rb.velocity = new Vector3(this._speed, 0, 0);

        this.StartCoroutine(this.Destroy());
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(1.9f);
        Destroy(this.gameObject);
    }
}
