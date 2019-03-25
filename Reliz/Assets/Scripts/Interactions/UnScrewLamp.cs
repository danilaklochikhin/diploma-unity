using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnScrewLamp : MonoBehaviour
{
    public GameObject tool;
    public GameObject lamp;
    public GameObject cap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (tool.GetComponent<Tool>().name == "hand")
        {
            if (cap.GetComponent<Cap>().connection)
            {

            }
        }
    }
}
