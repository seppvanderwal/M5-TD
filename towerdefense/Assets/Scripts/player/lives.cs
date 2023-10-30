using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lives : MonoBehaviour
{
    public static int hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)    
        {
            Debug.Log("balls");
        }
    }
}
