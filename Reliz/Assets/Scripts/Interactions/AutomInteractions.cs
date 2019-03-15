using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/AutomaticSwitch")]
public class AutomInteraction : Interactions
{
    private OnOffAutomat ofa;

    void Start()
    {
        initializOfa();
    }

    void initializOfa()
    {
        ofa.tool = tool;
        ofa.Automat = target;
    }
}