using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class bulletdie : MonoBehaviour
{
    public float countdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
