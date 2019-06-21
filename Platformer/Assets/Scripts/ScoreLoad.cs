using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ScoreLoad : MonoBehaviour
{
    public string fileName = "highscore.data";
    public string Scoreload;
    public Text HighScoreDisplay;

    public StreamReader sr;
    public string line;

    public static int CompareScore;

    void Start()
    {
        sr = new StreamReader(fileName);

        line = sr.ReadLine();
        while (line != null)
        {
            Scoreload = line;
            line = sr.ReadLine();
        }

        sr.Close();

        HighScoreDisplay.text = "" + Scoreload;

        CompareScore = int.Parse(Scoreload);

    }
}
