using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "New Interaction", menuName = "Scriptable Object/New Interaction")] // выпадающее меню редактора "Create"
public abstract class Interactions : ScriptableObject
{
    public GameObject target;
    public GameObject tool;
}

//[System.Serializable]
//public class Interaction: System.Object
//{
//    public Component script;
    //public GameObject go;

     //void addScript()
     //{
     //    if (script == "OnOffSwitch")
     //        gameObject.AddComponent<OnOffSwitch>();
     //    else if (script == "OnOffAutomat")
     //        go.AddComponent<OnOffAutomat>();
     //    else if (script == "ShineNonShine")
     //        go.AddComponent<ShineNonShine>();
     //    else if (script == "OnOffSwitch")
     //        go.AddComponent<OnOffSwitch>();
     //    else if (script == "UnScrewLamp")
     //        go.AddComponent<UnScrewLamp>(); 
     //}
//}
