using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/OnOff")]
public class OnOff : Interactions
{
    public override void initializ(GameObject objTool, GameObject objTarget)
    {
        tool = objTool;
        target = objTarget;
    }

    // Функция нажатия на объект
    // Входная переменная - объект над которым совершается действие
    public void press(GameObject go)
    {
        target = go;

        if (tool.GetComponent<Tool>().name == "hand")
        {
            if (target.tag == "switch")
            {
                if (target.GetComponent<Switch>().on)
                    target.GetComponent<Switch>().on = false;
                else
                    target.GetComponent<Switch>().on = true;
            }
            else if (target.tag == "Automate")
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
}
