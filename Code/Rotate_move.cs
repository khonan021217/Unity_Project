using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_move : MonoBehaviour
{
    public int rot_a = 90; //회전 각도
    public float movement_speed = 0.01f; //움직이는 속도
    int count = 0;
    public int currnt_time = 300;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count += 1;
        if(count >=currnt_time)
        {
            count = 0;
            this.transform.Rotate(0, 0, rot_a);
        }

        if (Input.GetKey("right")) this.transform.Translate(movement_speed, 0, 0);
        if (Input.GetKey("left")) this.transform.Translate(-movement_speed, 0, 0);
        if (Input.GetKey("up")) this.transform.Translate(0, movement_speed, 0);
        if (Input.GetKey("down")) this.transform.Translate(0, -movement_speed, 0);
    }
}