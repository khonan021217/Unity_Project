using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;
    public GameObject Laser;
    GameObject Health;
    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        this.Health = GameObject.Find("PHpbar");
    }

    // Update is called once per frame
    void Update()
    {
        if(this.Health.GetComponent<Image>().fillAmount < 0.2 && flag == false)
        {
            flag = true;
            GameObject.Find("player").GetComponent<PlaySound>().lastChance();
        }
        if (this.Health.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        Vector2 Pos = this.transform.position;

        if(Pos.x<2.9)
        {
            if (Input.GetKey("right"))
            {
                this.transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
        if(Pos.x > -2.9)
        {
            if (Input.GetKey("left"))
            {
                this.transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }
        if (Pos.y < 0.5)
        {
            if (Input.GetKey("up"))
            {
                this.transform.Translate(0, speed * Time.deltaTime, 0);
            }
        }
        if(Pos.y>-4.5)
        {
            if (Input.GetKey("down"))
            {
                this.transform.Translate(0, -speed * Time.deltaTime, 0);
            }
        }
        
        if (Input.GetKey("space"))
        {
            GameObject.Find("player").GetComponent<Laser_gen>().Shot();
        }
    }
}
