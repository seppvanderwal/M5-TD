using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using TMPro.Examples;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;    

public class turretaim : MonoBehaviour
{
    private findenemy Findenemy;
    public float speed = 10;

    // Start is called before the first frame update
    void Start() 
    {
        Findenemy = GetComponent<findenemy>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Findenemy.target == null)
        {
            return;
        }
        Vector3 dir = Findenemy.target.position - transform.position;
        Quaternion lookat = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(Findenemy.turret.rotation, lookat, Time.deltaTime * speed).eulerAngles;
        Findenemy.turret.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }
}
