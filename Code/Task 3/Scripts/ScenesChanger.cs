using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenesChanger : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
