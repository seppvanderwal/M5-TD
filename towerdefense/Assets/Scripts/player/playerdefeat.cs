using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdefeat : MonoBehaviour
{
    void Update()
    {
        if(lives.hp <= 1)
        {
            SceneManager.LoadScene(sceneName: "gameover");
        }
    }
}
