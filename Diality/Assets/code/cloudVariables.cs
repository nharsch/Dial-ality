using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudVariables : MonoBehaviour
{
    public bool raining;
    public int intensity;


    void Start()
    {
        this.raining = false;
        this.intensity = 0;
    }
}
