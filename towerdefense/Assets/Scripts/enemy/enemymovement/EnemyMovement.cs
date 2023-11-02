using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
   
    public float speed = 10;
    private Transform target;
    private int waveintIndex = 0;

    private void Start()
    {
        target = Waypoints.waypoints[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }
    void GetNextWaypoint()
    {
        if (waveintIndex >= Waypoints.waypoints.Length - 1)
        {
         
            return;
        }

        waveintIndex++;
        target = Waypoints.waypoints[waveintIndex];
    }
}
