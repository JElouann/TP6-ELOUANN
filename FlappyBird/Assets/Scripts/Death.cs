using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Death : MonoBehaviour
{

    [SerializeField]
    private GameObject Score;



    private void OnCollisionEnter(Collision collision)
    {
        
        End();
    }

    private void End()
    {
        Score.SendMessage("PrintEndScore");
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}


