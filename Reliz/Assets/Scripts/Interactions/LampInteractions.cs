using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Interactions/Lamp")]
public class LampInteractions : Interactions
{
    public GameObject L;
    public GameObject N;
    public GameObject cap;

    private ShineNonShine sns;
    private UnScrewLamp usl;

    void Start()
    {
        initializSns();
        initializUsl();
    }

    void initializSns()
    {
        sns.lamp = target;
        sns.cap = cap;
        sns.L = L;
        sns.N = N;
    }

    void initializUsl()
    {
        usl.lamp = target;
        usl.cap = cap;
        usl.tool = tool;
    }
}