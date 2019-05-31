using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/ScrewUnScrew")]
public class ScrewUnScrew : Interactions
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

    public void screw(GameObject go)
    {
        target = go;

        if (tool.GetComponent<Tool>().name == "screwdriver")
        {
            if (target.tag == "clam")
            {
                if (target.GetComponent<Clam>().screwed)
                {
                    target.GetComponent<Clam>().screwed = false;
                }
                else target.GetComponent<Clam>().screwed = true;
            }
        }
        else if (tool.GetComponent<Tool>().name == "hand")
        {
            ;
        }
    }
}
