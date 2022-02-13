using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ScenesChanger : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("MainGame");
        }
    }
}
