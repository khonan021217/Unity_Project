using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_left : MonoBehaviour
{
    public float rotateForceL = -0.02f;
    void Update()
    {
        this.transform.Rotate(0, 0, rotateForceL);
    }
}
