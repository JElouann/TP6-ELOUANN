using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public Death death;

    public IEnumerator Shake(float duration, float magnitude)
    {
        Debug.Log("shake");
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

        transform.localPosition = _startPos;
        death.End();
    }
}
