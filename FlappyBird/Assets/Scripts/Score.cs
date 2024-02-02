using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _text;
    private Rigidbody _rb;
    private int _score = 0;

    public void PrintEndScore()
    {
        Debug.Log($"Score final : {this._score}");
    }

    private void Start()
    {
        this._text.text = this._score.ToString();
        this._rb = this.GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider other)
    {
        this._score += 1;
        this._text.text = this._score.ToString();
    }
}
