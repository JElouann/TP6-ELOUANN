using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private Death _death;
    [SerializeField]
    private float _cameraShakeDuration;
    [SerializeField]
    private float _cameraShakeMagnitude;

    public IEnumerator Shake()
    {
        Vector3 _startPos = this.transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < this._cameraShakeDuration)
        {
            float x = Random.Range(-1f, 1f) * this._cameraShakeMagnitude;
            float y = Random.Range(-1f, 1f) * this._cameraShakeMagnitude;

            this.transform.localPosition = new Vector3(x, y, _startPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        yield return new WaitForSeconds(0.25f);
        this.transform.localPosition = _startPos;
        this._death.End();
    }
}
