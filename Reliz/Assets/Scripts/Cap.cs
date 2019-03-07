using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cap : MonoBehaviour
{
    public GameObject lamp;
    // public GameObject cap;
    public bool connection = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider otherObj)
    {
        if (otherObj.gameObject == lamp)
        {
            connection = true;
        }
        Debug.Log("con");
    }

    void OnTriggerExit(Collider otherObj)
    {
        if (otherObj.gameObject == lamp)
        {
            connection = false;
        }
        Debug.Log("no");
    }
}
