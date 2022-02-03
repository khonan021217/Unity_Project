using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_right : MonoBehaviour
{
    public float rotateForceR = 0.02f;
    void Update()
    {
        this.transform.Rotate(0, 0, rotateForceR);
    }
}
