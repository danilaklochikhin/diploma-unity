using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    public string type;
    public int group;
    public float U;
    //public bool onClamp = false;
    public GameObject clamp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        clamp = other.gameObject;
    }

    void OnTriggerExit(Collider other)
    {
        clamp = null;
    }
}
