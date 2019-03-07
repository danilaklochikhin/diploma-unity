using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "New Interaction", menuName = "Scriptable Object/New Interaction")] // выпадающее меню редактора "Create"
public class Interactions : ScriptableObject
{
    public Interaction [] items;
    //public OnOff onoff;
}

[System.Serializable]
public class Interaction
{
    public GameObject script;
}