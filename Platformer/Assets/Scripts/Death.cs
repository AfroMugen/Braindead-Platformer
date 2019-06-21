using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject DeathBlack;
    public GameObject DeathText;
    public GameObject Rocket;

    public AudioSource Crash;
    public GameObject MainAudio;

    public GameObject HighScore;

    void OnTriggerEnter(Collider other)
    {
        NextAxis.TheXAxis = 30.5f;
        HighScore.SetActive(true);
        Crash.Play();
        MainAudio.SetActive(false);
        DeathBlack.SetActive(true);
        DeathText.SetActive(true);
        Rocket.SetActive(false);
    }
}
