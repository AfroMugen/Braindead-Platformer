using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreSaver : MonoBehaviour
{
    public string fileName = "highscore.data";  
    public int ScoreAmount;
    public StreamWriter OurFile;

    public int HighScore;

    void Start()
    {
        HighScore = ScoreLoad.CompareScore;
        ScoreAmount = Scoring.TheScore;
        if (ScoreAmount >= HighScore)
        {
            OurFile = File.CreateText(fileName);
            OurFile.WriteLine(ScoreAmount);
            OurFile.Close();
        }       
    }
}
