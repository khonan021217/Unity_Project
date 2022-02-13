using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser_gen_Red : MonoBehaviour
{
    public GameObject GenerateObject;
    GameObject Pase;
    bool pase1 = false; bool pase2 = false; bool pase3 = false; bool lastpase = false;
    float respawn = 1.0f;
    float delta = 0;
    private void Start()
    {
        this.Pase = GameObject.Find("Hpbar");
    }

    public void Shot()
    {
        if (this.Pase.GetComponent<Image>().fillAmount < 0.75f && pase1 == false)
        {
            respawn -= 0.2f;
            pase1 = true;
        }
        if (this.Pase.GetComponent<Image>().fillAmount < 0.50f && pase2 == false) 
        { 
            respawn -= 0.2f;
            pase2 = true;
        }
        if (this.Pase.GetComponent<Image>().fillAmount < 0.25f && pase3 == false)
        {
            respawn -= 0.3f;
            pase3 = true;
        }
        if (this.Pase.GetComponent<Image>().fillAmount < 0.12f && lastpase == false)
        {
            respawn -= 0.15f;
            lastpase = true;
        }
        Vector2 pos = this.transform.position;
        this.delta += Time.deltaTime;
        if (this.delta > this.respawn)
        {
            this.delta = 0;
            GameObject tempheal = Instantiate(GenerateObject) as GameObject;
            float range = Random.Range(-2.8f, 2.8f);
            tempheal.transform.position = new Vector3(range, 4, 0);
            GameObject.Find("mothership_blue").GetComponent<PlaySound_E>().Shoot();
        }
    }
}
