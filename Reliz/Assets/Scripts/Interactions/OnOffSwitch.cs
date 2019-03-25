using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/OnOffSwitch")]
public class OnOffSwitch : Interactions
{
    //public GameObject tool;
    //public GameObject sw;

    //// Start is called before the first frame update
    //void Start()
    //{
      
    //}

    //// Update is called once per frame
    //void Update()
    //{
           
    //}

    public void press()
    {
        if (tool.GetComponent<Tool>().name == "hand")
        {
            if (target.GetComponent<Switch>().on)
                target.GetComponent<Switch>().on = false;
            else
                target.GetComponent<Switch>().on = true;
        }
    }
    public override void initializ(GameObject objTool, GameObject objTarget)
    {
        tool = objTool;
        target = objTarget;
    }
}