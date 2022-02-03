using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 pos;
    public float defultSpeed = 0.01f;
    public float defultJump = 1;
    float x_force = 0;
    float y_force = 0;
    float temp = 0;
    bool flipFlag = false;
    void Update()
    {
        x_force = 0; y_force = 0;
        if (Input.GetKey("right"))
        {
            x_force = defultSpeed;
        }
        if (Input.GetKey("left"))
        {
            x_force = -defultSpeed;
        }
        if (Input.GetKeyDown("up"))
        {
            y_force = defultJump;
        }
        this.transform.Translate(x_force, y_force, 0);
        if (x_force < 0) flipFlag = true;
        else if (x_force > 0) flipFlag = false;
        this.GetComponent<SpriteRenderer>().flipX = flipFlag;
        
    }
}
