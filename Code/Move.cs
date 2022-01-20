using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.0f;

    void FixedUpdate()
    {
        this.transform.Translate(speed / 50, 0, 0);   
    }
}
