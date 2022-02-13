using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Laser_con : MonoBehaviour
{
    GameObject Hpbar;
    private void Start()
    {
        this.Hpbar = GameObject.Find("Hpbar");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        this.Hpbar.GetComponent<Image>().fillAmount -= 0.02f;
        GameObject.Find("player").GetComponent<PlaySound>().hitt();
    }
    private void Update()
    {
        if(gameObject.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
