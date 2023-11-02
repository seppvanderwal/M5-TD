using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{
    
    private Transform End;
    
    void Start()
    {
        End = Waypoints.waypoints[8];
    }

    
    void Update()
    {
        
        if (transform.position.z >= End.transform.position.z) 
        {
            Destroy(gameObject);
            lives.hp--;
        }
    }
}