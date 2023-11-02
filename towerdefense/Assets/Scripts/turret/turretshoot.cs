using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class turretshoot : MonoBehaviour
{
    public GameObject bullet;
    private findenemy Findenemy;
    public GameObject bulletpoint;
    public float bulletSpeed = 50f; 
    private float cooldown = 0;

    void Start()
    {
        Findenemy = GetComponent<findenemy>();
    }

    void Update()
    {
        if (Findenemy.target && cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }
        else if (Findenemy.target && cooldown <= 0)
        {
            shoot();
            cooldown = 1;
        }
    }

    private void shoot()
    {
        GameObject newBullet = Instantiate(bullet, bulletpoint.transform.position, bulletpoint.transform.rotation);
        Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();
        if (bulletRigidbody)
        {
            Vector3 direction = Findenemy.target.transform.position - bulletpoint.transform.position;
            direction.Normalize();
            bulletRigidbody.velocity = direction * bulletSpeed;
        }
    }
}