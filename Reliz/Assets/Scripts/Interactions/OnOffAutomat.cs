using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/OnOffAutomat")]
public class OnOffAutomat : Interactions
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public override void initializ(GameObject objTool, GameObject objTarget)
    {
        tool = objTool;
        target = objTarget;
    }

    public void press()
    {
        //Debug.Log(tool.tag);
        //Debug.Log(tool.GetComponent<Tool>().name);
        if (tool.GetComponent<Tool>().name == "hand")
        {
            if (target.GetComponent<AutomaticSwitch>().on)
            {
                target.GetComponent<AutomaticSwitch>().on = false;
            }
            else
            {
                target.GetComponent<AutomaticSwitch>().on = true;
            }
        }
    }
}
