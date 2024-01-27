using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsFading : MonoBehaviour
{
    
    private Animator _animator;
    [SerializeField]
    private AnimationClip _clip;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        StartCoroutine(Fade());
    }

    private IEnumerator Fade()
    {
        yield return new WaitForSeconds(1.5f);
        _animator.Play(_clip.ToString());
        Debug.Log(_clip.ToString());
        StartCoroutine(SignalToDestroy());

    }

    private IEnumerator SignalToDestroy()
    {
        yield return new WaitForSeconds(1);
        gameObject.SendMessage("Destroy");
    }
}
