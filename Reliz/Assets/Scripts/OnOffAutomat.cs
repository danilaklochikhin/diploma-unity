using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffAutomat : MonoBehaviour
{
    public GameObject tool;
    public GameObject Automat;


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
            if (Automat.GetComponent<AutomaticSwitch>().on)
            {
                Automat.GetComponent<AutomaticSwitch>().on = false;
            }
            else
            {
                Automat.GetComponent<AutomaticSwitch>().on = true;
            }
        }
    }
}
