using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class findenemy : MonoBehaviour
{
    public Transform turret;
    public Transform target;
    public float range = 15f;
    public string enemytag = "Enemy";
    public float speed = 10;
    
    void Start()
    {
        InvokeRepeating("UpdateEnemy", 0f, 0.5f);
    }
     void UpdateEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemytag);
        float mindistance = Mathf.Infinity;
        GameObject nearestenemy = null;

        foreach(GameObject enemy in enemies)
        {
            
            float distance = Vector3.Distance(enemy.transform.position, transform.position);
            if(distance < mindistance )
            {
                mindistance = distance;
                nearestenemy = enemy;
                
            }
            if (nearestenemy != null && mindistance <= range)
            {
                target = nearestenemy.transform;

            }
            else
            {
                target = null;
            }
        }
    }
}
