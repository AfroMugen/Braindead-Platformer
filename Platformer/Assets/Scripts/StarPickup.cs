using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickup : MonoBehaviour
{
    public int Starscore = 500;
    public AudioSource StarSound;

    void OnTriggerEnter(Collider other)
    {
        StarSound.Play();
        Scoring.TheScore += Starscore;
        this.transform.position = new Vector3(0, 100, 0);
    }
}
