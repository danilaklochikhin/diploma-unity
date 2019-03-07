using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tools", menuName = "Scriptable Object/New Tools")] // выпадающее меню редактора "Create"
public class Tools : ScriptableObject
{
    public item [] items;
}

[System.Serializable]
public class item
{
    public string name;
}