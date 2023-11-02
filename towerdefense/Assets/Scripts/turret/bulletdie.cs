using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class bulletdie : MonoBehaviour
{
    public float countdown;
    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
        } else
        {
            Destroy(gameObject);
        }
    }
}
