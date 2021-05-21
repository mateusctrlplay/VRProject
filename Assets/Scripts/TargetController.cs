using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    
    void Start()
    {
        Invoke("Rotate", 2f);    
    }

    public void Rotate()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, Random.Range(-120, 120));

        Invoke("Rotate", 2f);
    }
}
