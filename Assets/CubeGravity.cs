using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGravity : MonoBehaviour
{
    public Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody.useGravity = true;
    }
}
