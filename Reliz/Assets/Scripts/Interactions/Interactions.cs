using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactions : ScriptableObject
{
    public GameObject target;
    public GameObject tool;

    public abstract void initializ(GameObject objTool, GameObject objTarget);
}
