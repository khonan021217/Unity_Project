using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipCOn : MonoBehaviour
{
    

    Vector2 pos;
    private int mv_flag_x = 0;
    private int mv_flag_y = 0;
    private int prologue = 0;
    void Start()
    {
        prologue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(prologue == 0)
        {
            pos = this.gameObject.transform.position;
            if (mv_flag_x == 0 && pos.x < 7.75)
            {
                this.transform.Translate(3 * Time.deltaTime, 0, 0);
            }
            else
            {
                mv_flag_x++;
                if (mv_flag_y == 0)
                {
                    mv_flag_y++;
                    this.transform.position = new Vector3(0, 7, 0);
                }
                else if (pos.y > 4.72)
                {
                    this.transform.Translate(0, (-0.33f * Time.deltaTime), 0);
                }
                else
                {
                    prologue++;
                }
            }
        }
        else
        {
            GameObject.Find("mothership_blue").GetComponent<Laser_gen_Red>().Shot();
        }
    }
}
