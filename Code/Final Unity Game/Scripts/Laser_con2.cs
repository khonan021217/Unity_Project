using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Laser_con2 : MonoBehaviour
{
    GameObject Player_Hpbar;
    private void Start()
    {
        this.Player_Hpbar = GameObject.Find("PHpbar");
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);
        this.Player_Hpbar.GetComponent<Image>().fillAmount -= 0.2f;
        GameObject.Find("mothership_blue").GetComponent<PlaySound_E>().hitt();
    }
    private void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
