using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/Switch")]
public class SwitchInteraction : Interactions
{
    private OnOffSwitch ofs;

    void Start()
    {
        initializOfs();
    }

    void initializOfs()
    {
        ofs.tool = tool;
        ofs.sw = target;
    }
}