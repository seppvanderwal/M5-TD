using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public class turretplace : MonoBehaviour
{
    public GameObject tower;
    public bool nodeOccupied;
    public GameObject upgrade;
    // Start is called before the first frame update
    void Start()
    {
        nodeOccupied = false;
        upgrade.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (!nodeOccupied)
        {
            placeTower();
            
        }  else
        {
            upgrade.SetActive(true);
        }
    }
    private void placeTower()
    {
        Instantiate(tower,new Vector3(transform.position.x, 0.75f, transform.position.z), transform.rotation);
        nodeOccupied = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
