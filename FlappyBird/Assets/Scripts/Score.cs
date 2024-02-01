using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI Text;

    Rigidbody rb;

    private int _score = 0;


    private void Start()
    {
        Text.text = _score.ToString();
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider other)
    {
        _score += 1;
        Text.text = _score.ToString();
    }

    public void PrintEndScore()
    {
        Debug.Log($"Score final : {_score}");
    }
}
