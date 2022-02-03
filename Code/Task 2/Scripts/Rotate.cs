using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateForceZ = 0.02f;
    void Update()
    {
        this.transform.Rotate(rotateForceZ, 0, 0);
    }
}
