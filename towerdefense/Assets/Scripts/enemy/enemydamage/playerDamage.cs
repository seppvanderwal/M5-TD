using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{
    
    private Transform End;
    // Start is called before the first frame update
    void Start()
    {
        End = Waypoints.waypoints[8];
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z >= End.transform.position.z) 
        {
            Destroy(gameObject);
            lives.hp --;
            
        }
    }
    
}