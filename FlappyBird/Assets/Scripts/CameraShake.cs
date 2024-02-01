using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private Death _death;

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 _startPos = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, _startPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        yield return new WaitForSeconds(0.25f);
        transform.localPosition = _startPos;
        _death.End();
    }
}
