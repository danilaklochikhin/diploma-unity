using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSwitch : MonoBehaviour
{
    public GameObject tool;
    public GameObject sw;

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
           if (sw.GetComponent<Switch>().on)
               sw.GetComponent<Switch>().on = false;
           else
               sw.GetComponent<Switch>().on = true;
       }
    }
}