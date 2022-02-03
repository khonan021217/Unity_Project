using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Nextstage : MonoBehaviour
{
    string [] scenelist = new string[] { "Stage2"};
    int i = 0;
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(scenelist[i]);
            i++;
        }
    }
}
