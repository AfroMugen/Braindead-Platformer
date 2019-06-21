using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public static int TheScore;
    public Text Score;

    // Start is called before the first frame update
    void Start()
    {
        TheScore = 0;
        InvokeRepeating("AddScore", 1.0f, 0.1f);
    }

    public void AddScore()
    {
        TheScore += 5;
        Score.text = "Score: " + TheScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
