using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject player;
    GameObject potato;
    GameObject distance;

    float lengthDis;
    void Start()
    {
        this.player = GameObject.Find("cat");
        this.potato = GameObject.Find("potato");
        this.distance = GameObject.Find("distance");
    }
    
    void Update()
    {
        lengthDis = (this.potato.transform.position.x) - (this.player.transform.position.x);
        if(lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표지점 :" + lengthDis.ToString() + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over!!";
            SceneManager.LoadScene("GameOver");
        }
    }
}
