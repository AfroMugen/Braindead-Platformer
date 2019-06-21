using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject Section01;
    public GameObject Section02;

    public float NewXAxis = NextAxis.TheXAxis;
    public int GenSec;
    public GameObject NewSec;
    public Vector3 NextPosition = new Vector3(NextAxis.TheXAxis, 7.35f, -18.94759f);

    void OnTriggerEnter(Collider other)
    {
        NextPosition = new Vector3(NextAxis.TheXAxis, 7.35f, -18.94759f);
        GenSec = Random.Range(1, 3);
        NewXAxis = NextAxis.TheXAxis;

        if (GenSec == 1)
        {
            NewSec = Section01;
        }

        if (GenSec == 2)
        {
            NewSec = Section02;
        }

        Instantiate(NewSec, NextPosition, Quaternion.identity);
        NextAxis.TheXAxis += 500;
    }
}