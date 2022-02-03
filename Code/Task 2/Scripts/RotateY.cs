using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    public float rotateForceY = 0.02f;
    void Update()
    {
        this.transform.Rotate(0, rotateForceY, 0);
    }
}
