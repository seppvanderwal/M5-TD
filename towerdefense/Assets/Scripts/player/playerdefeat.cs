using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdefeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives.hp <= 1)
        {
            Debug.Log("test");
               
            SceneManager.LoadScene(sceneName: "gameover");
        }
    }
}
