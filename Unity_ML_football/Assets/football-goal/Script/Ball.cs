using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static bool complete;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "感應區")
            {
            complete = true;
            }
    }
}
