using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAxis : MonoBehaviour
{
    public static float TheXAxis = 30.5f;
    public float InternalAxis;

    void Update()
    {
        InternalAxis = TheXAxis;
        Debug.Log(TheXAxis);
    }
}

