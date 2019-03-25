using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "new Tool")]
public class Tools : ScriptableObject
{
    public string name; //Наименование  инструмента 
    public Sprite image; //Отображение на панели интрументов
    public GameObject panel; //Панель, на которой расположен инструмент

    public void initializ(GameObject objPanel)
    {
        panel = objPanel;
    }
    public void DrawPanel()
    {
        panel.GetComponent<Image>().sprite = image;
    }
    //private Tool t;

    //void Start ()
    //{
    //    initializTool();
    //    initializDraw();
    //}

    //public void initializDraw()
    //{
    //    dt.panel = panel;
    //    dt.image = image;
    //}
    //void initializTool()
    //{
    //    t = tool.GetComponent<Tool>();
    //    t.name = name;
    //}
}

