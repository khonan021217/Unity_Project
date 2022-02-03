using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;
    float length;
    public float delta = 1000.0f;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            length = (this.endPos.x - this.startPos.x);
            this.speed = length / delta;
            this.GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.96f;
    }
}
