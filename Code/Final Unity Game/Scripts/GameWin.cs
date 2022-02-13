using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameWin : MonoBehaviour
{
    GameObject win;
    private void Start()
    {
        this.win = GameObject.Find("Hpbar");
    }
    void Update()
    {
        if (this.win.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("GameWin");
        }
    }
}
