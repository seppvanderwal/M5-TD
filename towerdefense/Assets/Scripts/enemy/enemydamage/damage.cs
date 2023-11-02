using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int hp;
    public string collidertag;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == collidertag)
        {
            hp--;
        }
    }
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
