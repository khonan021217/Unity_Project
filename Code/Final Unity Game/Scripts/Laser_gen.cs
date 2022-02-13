using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_gen : MonoBehaviour
{
    public GameObject GenerateObject;
    float respawn = 1f;
    float delta = 0;

    public void Shot()
    {
        Vector2 pos = this.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.respawn)
        {
            this.delta = 0;
            GameObject tempheal = Instantiate(GenerateObject) as GameObject;
            tempheal.transform.position = new Vector3(pos.x, pos.y+1, 0);
            GameObject.Find("player").GetComponent<PlaySound>().Shoot();
        }
    }
}
