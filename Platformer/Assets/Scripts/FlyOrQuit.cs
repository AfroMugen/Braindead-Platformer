using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyOrQuit : MonoBehaviour
{
    public void OnGUI()
    {
        if (GUI.Button (new Rect(Screen.width/2 - 400,Screen.height - 150, 350, 125), "Fly Again"))
        {
            SceneManager.LoadScene(2);
        }

        if (GUI.Button(new Rect(Screen.width/2 + 50, Screen.height - 150, 350, 125), "Main Menu"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
