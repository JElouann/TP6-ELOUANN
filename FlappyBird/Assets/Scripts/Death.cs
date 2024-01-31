using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Death : MonoBehaviour
{

    [SerializeField]
    private GameObject Score;
 
    public CameraShake cameraShake;

    [SerializeField]
    private float ShakeDuration;
    [SerializeField]
    private float ShakeMagnitude;


    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(cameraShake.Shake(ShakeDuration, ShakeMagnitude));
    }

    public void End()
    {
        Score.SendMessage("PrintEndScore");
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}


