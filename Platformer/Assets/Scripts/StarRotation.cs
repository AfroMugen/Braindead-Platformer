using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour
{
    public int Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Speed, 0, Space.World);
    }
}
